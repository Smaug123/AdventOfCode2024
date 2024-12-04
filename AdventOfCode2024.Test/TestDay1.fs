namespace AdventOfCode2024.Test

open FsUnitTyped
open AdventOfCode2024
open NUnit.Framework
open System.Reflection

[<TestFixture>]
module TestDay1 =
    [<Literal>]
    let private filename = "day1.txt"

    [<Test>]
    let ``Part 1, given example`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day1.part1 input |> shouldEqual 11

    [<Test ; Explicit>]
    let ``Part 1`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day1.part1 input |> shouldEqual 1579939

    [<Test>]
    let ``Part 2, given example`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day1.part2 input |> shouldEqual 31

    [<Test ; Explicit>]
    let ``Part 2`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day1.part1 input |> shouldEqual 20351745
