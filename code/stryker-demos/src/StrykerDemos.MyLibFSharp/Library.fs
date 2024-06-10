namespace StrykerDemos.MyLibFSharp

open Microsoft.FSharp.Core

module SomeService =
    let isSmallerThan (baseLine: int) (value: int) =
        value < baseLine