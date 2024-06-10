module Tests

open StrykerDemos.MyLibFSharp
open Swensen.Unquote
open Xunit

[<Fact>]
let ``check if value is smaller than baseLine`` () =
    let value = 3
    let baseLine = 5
    let actual = SomeService.isSmallerThan baseLine value
    true =! actual

[<Fact>]
let ``check if value is larger than baseLine`` () =
    let value = 8
    let baseLine = 5
    let actual = SomeService.isSmallerThan baseLine value
    false =! actual