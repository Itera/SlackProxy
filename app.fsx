#r "packages/Suave/lib/net40/Suave.dll"

open System
open System.Data
open Suave
open Suave.Web
open Suave.Http

let app : WebApi = 
    choose
        [GET >>= choose
            [ path "/ok" >>= Ok html
              path "/" >>= Error html]
        ]