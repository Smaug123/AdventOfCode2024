namespace AdventOfCode2024.Test

open FsUnitTyped
open AdventOfCode2024
open NUnit.Framework
open System.Reflection

[<TestFixture>]
module TestDay2 =
    [<Literal>]
    let private filename = "day2.txt"

    [<Test>]
    let ``Part 1, given example`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day2.part1 input |> shouldEqual 2

    [<Test ; Explicit>]
    let ``Part 1`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day2.part1 input |> shouldEqual 442

    [<Test>]
    let ``Part 2, given example`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day2.part2 input |> shouldEqual 4

    [<Test ; Explicit>]
    let ``Part 2`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename
        Day2.part1 input |> shouldEqual 493
