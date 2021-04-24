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

let capitalise (s:string) = (Char.ToUpper(s.[0]).ToString()) + s.[1..]

type FieldType =
    | SimpleField of field:BuiltInTypeKind
    | Collection of FieldType
    | KeyValuePair of FieldType
    | LiteralField of name:string
    | TypeReference of name:string
    member this.Name =
        match this with
        | SimpleField BuiltInTypeKind.Int -> "int"
        | SimpleField BuiltInTypeKind.String -> "string"
        | SimpleField BuiltInTypeKind.Bool -> "bool"
        | SimpleField (BuiltInTypeKind.Object | BuiltInTypeKind.Any) -> "obj"
        | SimpleField b -> failwith $"Unknown simple field {b}"
        | Collection f -> $"{f.Name} array"
        | KeyValuePair f -> $"Map<string, {f.Name}>"
        | LiteralField n | TypeReference n -> n

type ResourceField =
    {
        Name : string
        Description : string option
        TypeInfo : {| FieldType: FieldType; Optional : bool |}
    }
    member this.Emit () =
        [
            match this.Description with Some d -> indent 3 + $"/// {d}" | None -> ()
            indent 3 + $"``{this.Name}`` : {this.TypeInfo.FieldType.Name}" + (if this.TypeInfo.Optional then " option" else "")
        ]
type TypeKind =
    | Record of {| Fields:ResourceField list; TypeName : string |}
    | DiscriminatedUnion of {| Cases:string list; TypeName : string |}

type ResourceDef =
    {
        Module : string
        Namespace : string
        TypeKind : TypeKind
        // Fields : ResourceField list
        // Name : string
    }
    member this.Emit () =
        [
            match this.TypeKind with
            | Record record ->
                indent 1 + $"type {record.TypeName} ="
                indent 2 + "{"
                for field in record.Fields do yield! field.Emit()
                indent 2 + "}"
                let args =
                    [
                        for field in record.Fields |> Seq.sortBy(fun r -> r.TypeInfo.Optional) do
                            (if field.TypeInfo.Optional then "?" else "") + $"``{field.Name}``"
                    ] |> String.concat ", "
                indent 2 + $"static member create({args}) ="
                indent 3 + "{"
                for field in record.Fields do
                    indent 4 + $"``{field.Name}`` = ``{field.Name}``"
                indent 3 + "}"
            | DiscriminatedUnion union ->
                indent 1 + $"type {union.TypeName} ="
                for case in union.Cases do
                    indent 2 + $"| {case}"
        ]

let (|Dictionary|Schemas|Standard|) (ot:ObjectType) =
    if ot.Name.StartsWith "Dictionary<string," then
        Dictionary
    elif ot.Name.StartsWith "schemas:" then
        Schemas
    else
        Standard

type Generator() =
    static member fieldTypeInfo (name:string) (flags:ObjectPropertyFlags) (tb:TypeBase) : {| FieldType : FieldType; Optional : bool |} =
        let propType =
            match tb with
            | :? BuiltInType as bit ->
                SimpleField bit.Kind
            | :? StringLiteralType as s ->
                LiteralField s.Value
            | :? UnionType ->
                TypeReference (capitalise name)
            | :? ObjectType as ot ->
                match ot with
                | Dictionary ->
                    let t = Generator.fieldTypeInfo name ObjectPropertyFlags.Required ot.AdditionalProperties.Type
                    KeyValuePair t.FieldType
                | Schemas ->
                    TypeReference "Properties"
                | Standard ->
                    TypeReference ot.Name
            | :? ArrayType as a ->
                let r = Generator.fieldTypeInfo name ObjectPropertyFlags.None a.ItemType.Type
                Collection r.FieldType
            | _ ->
                failwith $"Unknown type '{tb}'"
        {|
            FieldType = propType
            Optional = not (flags.HasFlag ObjectPropertyFlags.Required)
        |}

    static member properties (KeyValue(name:string, op:ObjectProperty)) =
        let fieldTypeInfo = Generator.fieldTypeInfo name op.Flags op.Type.Type
        match op.Type.Type with
        | :? StringLiteralType ->
            None
        | _ ->
            Some
                {
                    Description = if not (String.IsNullOrWhiteSpace op.Description) then Some op.Description else None
                    Name = name
                    TypeInfo = fieldTypeInfo
                }

    static member types (objectType:ObjectType) =
        [
            match objectType.Name with
            | null ->
                ()
            | name ->
                Record
                    {|
                        TypeName =
                            if name.StartsWith "schemas:" then "Properties"
                            else name
                        Fields =
                            [
                                for prop in objectType.Properties do
                                    yield! Option.toList (Generator.properties prop)
                            ]
                    |}

            for prop in objectType.Properties do
                match prop.Value.Type.Type with
                | :? ObjectType as ot ->
                    match ot.AdditionalProperties with
                    | null ->
                        yield! Generator.types ot
                    | props ->
                        match props.Type with
                        | :? ObjectType as ot ->
                            yield! Generator.types ot
                        | _ ->
                            ()
                | :? ArrayType as at ->
                    match at.ItemType.Type with
                    | :? ObjectType as ot ->
                        match ot.AdditionalProperties with
                        | null ->
                            yield! Generator.types ot
                        | props ->
                            match props.Type with
                            | :? ObjectType as ot ->
                                yield! Generator.types ot
                            | _ ->
                                ()
                    | _ ->
                        ()
                | :? UnionType as ut ->
                    let cases = ut.Elements |> Array.map(fun e -> Generator.fieldTypeInfo "" ObjectPropertyFlags.None e.Type) |> Array.toList
                    DiscriminatedUnion
                        {| Cases = cases |> List.map (fun e -> e.FieldType.Name)
                           TypeName = capitalise prop.Key |}
                | _ ->
                    ()
        ]

    static member resourceDefinition (resourceType:ResourceType) =
        match resourceType.Name.Split '@' with
        | [| ns; moduleName |] ->
            let ns =
                ns.Split '/'
                |> Seq.map (fun r -> $"{capitalise r}")
                |> String.concat "."
            let typeKinds =
                match resourceType.Body.Type with
                | :? ObjectType as ot -> Generator.types ot
                | _ -> failwith "Unkown"
            [
                for typeKind in typeKinds do
                {
                    Namespace = ns
                    Module = moduleName
                    TypeKind =
                        match typeKind with
                        | Record r ->
                            Record
                                {| r with
                                    TypeName =
                                        if r.TypeName.Contains "/" then
                                            ns.Split '.' |> Array.last |> singular
                                        else
                                            r.TypeName
                                |}
                        | _ ->
                            typeKind

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
    |> Seq.collect Generator.resourceDefinition
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

let sa =
    let typeLoader = Az.TypeLoader()
    typeLoader.GetIndexedTypes().Types
    |> Seq.filter(fun r -> r.Key.StartsWith "Microsoft.Storage/storageAccounts")
    |> Seq.map (fun r -> typeLoader.LoadResourceType r.Value)
    |> Seq.filter (fun r -> r.ScopeType = ScopeType.ResourceGroup)
    |> Seq.find(fun r -> r.Name = "Microsoft.Storage/storageAccounts@2019-06-01")

let saT = sa.Body.Type :?> ObjectType
let propT = saT.Properties.["kind"].Type.Type :?> UnionType
propT.Elements.[0].Type

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