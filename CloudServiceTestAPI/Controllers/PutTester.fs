namespace CloudServiceTestAPI.Controllers

open System
open System.Collections.Generic
open System.Text.Json
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open CloudServiceTestAPI
open CloudServiceTestAPI.Models


[<ApiController>]
[<Route("api/putTester")>]
type PutTesterController () =
    inherit ControllerBase()

    [<HttpPut>]
    member this.Put([<FromBody>] value : PersonalData) : IActionResult =
        Console.WriteLine("Put Sucsess")
        this.Ok()
        