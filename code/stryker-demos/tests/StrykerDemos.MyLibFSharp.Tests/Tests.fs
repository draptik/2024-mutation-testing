module Tests

open StrykerDemos.MyLibFSharp
open Swensen.Unquote
open Xunit

[<Fact>]
let ``My test`` () =
    let actual = Say.hello "test"
    "test" =! actual