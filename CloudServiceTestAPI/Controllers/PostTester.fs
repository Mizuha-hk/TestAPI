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
[<Route("api/postTester")>]
type PostTesterController () =
    inherit ControllerBase()

    [<HttpPost>]
    member this.Post([<FromBody>] value : PersonalData) : IActionResult =
        Console.WriteLine("Post Sucsessful.")
        this.Ok()
        