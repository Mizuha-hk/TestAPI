namespace CloudServiceTestAPI.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open CloudServiceTestAPI

[<ApiController>]
[<Route("api/getTester")>]
type GetTesterController (logger : ILogger<GetTesterController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        Console.WriteLine("Get Sucsessful")
        let test = "TestGetMethod"
        test
        