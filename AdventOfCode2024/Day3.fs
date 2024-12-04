namespace AdventOfCode2024

open System
open System.Globalization
open System.Text.RegularExpressions

[<RequireQualifiedAccess>]
module Day3 =
    let part1 (input : string) =
        let regex = Regex @"mul\(([0-9]{1,3}),([0-9]{1,3})\)"
        let mutable result = 0

        for m in regex.Matches input do
            result <-
                result
                + (Int32.Parse (m.Groups.[1].ValueSpan, CultureInfo.InvariantCulture)
                   * (Int32.Parse (m.Groups.[2].ValueSpan, CultureInfo.InvariantCulture)))

        result

    let part2 (input : string) =
        let regex = Regex @"mul\(([0-9]{1,3}),([0-9]{1,3})\)"
        let mutable result = 0

        for m in regex.Matches input do
            let precedingDont = input.LastIndexOf ("don't()", m.Index)
            let precedingDo = input.LastIndexOf ("do()", m.Index)

            if precedingDont < 0 || precedingDo > precedingDont then
                result <-
                    result
                    + (Int32.Parse (m.Groups.[1].ValueSpan, CultureInfo.InvariantCulture)
                       * (Int32.Parse (m.Groups.[2].ValueSpan, CultureInfo.InvariantCulture)))

        result
