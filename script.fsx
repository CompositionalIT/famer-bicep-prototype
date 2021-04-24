#r "nuget: Azure.Bicep.Types.Az, 0.1.112"

open Azure.Bicep.Types
open Azure.Bicep.Types.Concrete
open System

[<AutoOpen>]
module Writers =
    let namespaceOpen ns = $"namespace {ns}
"
    let moduleOpen m = $"module ``{m}`` ="
    let openNamespaces = "open System
open System.Collections.Generic
"
    let singular (s:string) =
        if s.EndsWith "ies" then s.[0..s.Length - 4] + "y"
        elif s.EndsWith "s" then s.[0..s.Length - 2]
        else s
    let indent n = String.replicate n "    "

type ResourceFieldType = { TypeName : string; Optional : bool; IsCollection : bool }
type ResourceField =
    {
        Name : string
        Description : string option
        TypeInfo : ResourceFieldType
    }
    member this.Emit () =
        [
            match this.Description with Some d -> indent 3 + $"/// {d}" | None -> ()
            indent 3 + $"``{this.Name}`` : {this.TypeInfo.TypeName}" + (if this.TypeInfo.IsCollection then " array" else "") + (if this.TypeInfo.Optional then " option" else "")
        ]
type ResourceDef =
    {
        Module : string
        Namespace : string
        Fields : ResourceField list
        Name : string
    }
    member this.Emit () =
        [
            indent 1 + $"type {this.Name} ="
            indent 2 + "{"
            for field in this.Fields do yield! field.Emit()
            indent 2 + "}"
            let args =
                [
                    for field in this.Fields |> Seq.sortBy(fun r -> r.TypeInfo.Optional) do
                        (if field.TypeInfo.Optional then "?" else "") + $"``{field.Name}``"
                ] |> String.concat ", "
            indent 2 + $"static member create({args}) ="
            indent 3 + "{"
            for field in this.Fields do
                indent 4 + $"``{field.Name}`` = ``{field.Name}``"
            indent 3 + "}"
        ]

type Generator() =
    static let capitalise (s:string) = (Char.ToUpper(s.[0]).ToString()) + s.[1..]
    static member genType (name:string) (flags:ObjectPropertyFlags) (tb:TypeBase) : ResourceFieldType =
        let propType =
            match tb with
            | :? BuiltInType as bit ->
                match bit.Kind with
                | BuiltInTypeKind.String -> {| Type = "string"; IsCollection = false |}
                | BuiltInTypeKind.Bool -> {| Type = "bool"; IsCollection = false |}
                | BuiltInTypeKind.Int -> {| Type = "int"; IsCollection = false |}
                | BuiltInTypeKind.Object -> {| Type = "obj"; IsCollection = false |}
                | BuiltInTypeKind.Any -> {| Type = "obj"; IsCollection = false |}
                | x -> {| Type = $"unknown ({x})"; IsCollection = false |}
            | :? StringLiteralType as s ->
                {| Type = s.Value; IsCollection = false |}
            | :? UnionType as t ->
                {| Type = $"obj // {capitalise name}"; IsCollection = false |}
            | :? ObjectType as ot ->
                if ot.Name.StartsWith "Dictionary<string," then
                    let t = Generator.genType name ObjectPropertyFlags.Required ot.AdditionalProperties.Type
                    {| Type = $"Map<string, {t.TypeName}>"; IsCollection = false |}
                else
                    {| Type = ot.Name; IsCollection = false |}
            | :? ArrayType as a ->
                let r = Generator.genType name ObjectPropertyFlags.None a.ItemType.Type
                {| Type = r.TypeName; IsCollection = true |}
            | _ ->
                failwith $"Unknown type '{tb}'"
        {
            TypeName =
                if propType.Type.StartsWith "schemas:" then "Properties"
                else propType.Type
            IsCollection = propType.IsCollection
            Optional = not (flags.HasFlag ObjectPropertyFlags.Required)
        }

    static member genProp (KeyValue(name:string, op:ObjectProperty)) =
        let rft = Generator.genType name op.Flags op.Type.Type
        match op.Type.Type with
        | :? StringLiteralType ->
            None
        | _ ->
            Some
                {
                    Description = if not (String.IsNullOrWhiteSpace op.Description) then Some op.Description else None
                    Name = name
                    TypeInfo = rft
                }

    static member findTypes (objectType:ObjectType) =
        [
            match objectType.Name with
            | null ->
                ()
            | name ->
                {|
                    TypeName =
                        if name.StartsWith "schemas:" then "Properties"
                        else name
                    Fields =
                        [
                            for prop in objectType.Properties do
                                yield! Option.toList (Generator.genProp prop)
                        ]
                |}
            for prop in objectType.Properties do
                match prop.Value.Type.Type with
                | :? ObjectType as ot ->
                    match ot.AdditionalProperties with
                    | null ->
                        yield! Generator.findTypes ot
                    | props ->
                        match props.Type with
                        | :? ObjectType as ot ->
                            yield! Generator.findTypes ot
                        | _ ->
                            ()
                | :? ArrayType as at ->
                    match at.ItemType.Type with
                    | :? ObjectType as ot ->
                        match ot.AdditionalProperties with
                        | null ->
                            yield! Generator.findTypes ot
                        | props ->
                            match props.Type with
                            | :? ObjectType as ot ->
                                yield! Generator.findTypes ot
                            | _ ->
                                ()
                    | _ ->
                        ()
                | _ ->
                    ()
        ]

    static member genRec (resourceType:ResourceType) =
        match resourceType.Name.Split '@' with
        | [| ns; moduleName |] ->
            let ns =
                ns.Split '/'
                |> Seq.map (fun r -> $"{capitalise r}")
                |> String.concat "."
            let types =
                match resourceType.Body.Type with
                | :? ObjectType as ot -> Generator.findTypes ot
                | _ -> failwith "Unkown"
            [
                for t in types do
                {
                    Namespace = ns
                    Module = moduleName
                    Fields = t.Fields
                    Name =
                        if t.TypeName.Contains "/" then
                            ns.Split '.' |> Array.last |> singular
                        else
                            t.TypeName
                }
            ]
        | _ ->
            failwith "Unknown name structure!"

let storageAccounts =
    let typeLoader = Az.TypeLoader()
    typeLoader.GetIndexedTypes().Types
    |> Seq.filter(fun r -> r.Key.StartsWith "Microsoft.Storage/storageAccounts")
    |> Seq.map (fun r -> typeLoader.LoadResourceType r.Value)
    |> Seq.filter (fun r -> r.ScopeType = ScopeType.ResourceGroup)
    |> Seq.collect Generator.genRec
    |> Seq.toArray

let groupedByType =
    storageAccounts
    |> Seq.groupBy(fun r -> r.Namespace)
    |> Seq.sortBy fst
    |> Seq.collect(fun (ns, types) ->
        seq {
            namespaceOpen ns
            let byModule = types |> Seq.groupBy(fun t -> t.Module)
            for m, types in byModule do
                moduleOpen m
                for t in types |> Seq.rev |> Seq.distinct do
                    yield! t.Emit()
            // let m, types = types |> Seq.groupBy(fun t -> t.Module) |> Seq.last
            // moduleOpen m
            // for t in types |> Seq.rev |> Seq.distinct do
            //     yield! t.Emit()
        }
    )
    |> String.concat Environment.NewLine

System.IO.File.WriteAllText ("output.fsx", groupedByType)

// let sa =
//     let typeLoader = Az.TypeLoader()
//     typeLoader.GetIndexedTypes().Types
//     |> Seq.filter(fun r -> r.Key.StartsWith "Microsoft.Storage/storageAccounts")
//     |> Seq.map (fun r -> typeLoader.LoadResourceType r.Value)
//     |> Seq.filter (fun r -> r.ScopeType = ScopeType.ResourceGroup)
//     |> Seq.find(fun r -> r.Name = "Microsoft.Storage/storageAccounts/managementPolicies@2019-06-01")

// let saT = sa.Body.Type :?> ObjectType
// let propT = saT.Properties.["properties"].Type.Type :?> ObjectType
// let policy = propT.Properties.["policy"].Type.Type :?> ObjectType
// let rules = policy.Properties.["rules"].Type.Type :?> ArrayType
// let definition = (rules.ItemType.Type :?> ObjectType).Properties.["definition"].Type.Type :?> ObjectType
// let actions = definition.Properties.["actions"].Type.Type :?> ObjectType
// let version = actions.Properties.["version"].Type.Type :?> ObjectType

// version.Properties.["tierToCool"].Type.Type :?> ObjectType

// let at = propT.Properties.["userAssignedIdentities"].Type.Type :?> ObjectType
// at.AdditionalProperties.Type

// saT.Properties.["id"].Type.Type :?> ObjectType

// let props = Generator.findTypes saT
// props |> Seq.distinct |> Seq.map (fun r -> r.TypeName) |> Seq.toArray

// let x = sa |> Generator.genRec
// x.[2]



// let typeLoader = Az.TypeLoader()
// let all = typeLoader.GetIndexedTypes()
// let theType = typeLoader.LoadResourceType(all.Types.["Microsoft.ApiManagement/service/openidConnectProviders@2016-07-07"])