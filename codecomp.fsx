#load "output.fsx"

open Microsoft.Storage.StorageAccounts.``2021-02-01``

let x = StorageAccount.create("isaac", Sku())