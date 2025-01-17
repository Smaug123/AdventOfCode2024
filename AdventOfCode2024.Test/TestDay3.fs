﻿namespace AdventOfCode2024.Test

open FsUnitTyped
open AdventOfCode2024
open NUnit.Framework
open System.Reflection

[<TestFixture>]
module TestDay3 =
    [<Literal>]
    let private filename1 = "day31.txt"

    [<Literal>]
    let private filename2 = "day32.txt"

    [<Test>]
    let ``Part 1, given example`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename1
        Day3.part1 input |> shouldEqual 161

    [<Test ; Explicit>]
    let ``Part 1`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename1
        Day3.part1 input |> shouldEqual 190604937

    [<Test>]
    let ``Part 2, given example`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename2
        Day3.part2 input |> shouldEqual 48

    [<Test ; Explicit>]
    let ``Part 2`` () =
        let input = Assembly.readResource (Assembly.GetExecutingAssembly ()) filename2
        Day3.part2 input |> shouldEqual 82857512
