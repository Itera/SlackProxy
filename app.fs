open System
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
    
let app =
    choose
        [ GET >=> choose
            [ path "/" >=> OK "Index"
              path "/ok" >=> OK "OK" ]]

              
[<EntryPoint>]
let main argv = 
    startWebServer defaultConfig app
    0