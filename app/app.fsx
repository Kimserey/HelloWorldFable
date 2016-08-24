#r "../node_modules/fable-core/Fable.Core.dll"

open System
open Fable
open Fable.Import
open Fable.Import.Browser

let div =  document.getElementById("test")
div.innerText <- "Hello world!"