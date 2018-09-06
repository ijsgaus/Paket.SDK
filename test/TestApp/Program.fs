// Learn more about F# at http://fsharp.org

open System
open Newtonsoft.Json

[<EntryPoint>]
let main argv =
    printfn "String with JSon: %s" (JsonConvert.SerializeObject("Htllo from SDK"))

    0 // return an integer exit code
