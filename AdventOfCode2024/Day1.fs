namespace AdventOfCode2024

open System
open System.Collections.Generic
open System.Globalization

[<RequireQualifiedAccess>]
module Day1 =
    let getColumns (input : string) =
        let lines = input.AsSpan().Split '\n'
        let firstCol = ResizeArray ()
        let secondCol = ResizeArray ()

        for line in lines do
            let line =
                input.AsSpan().Slice (line.Start.Value, line.End.Value - line.Start.Value)

            let mutable isFirst = true

            for i in line.Split ' ' do
                let i = line.Slice (i.Start.Value, i.End.Value - i.Start.Value)

                if not i.IsEmpty then
                    if isFirst then
                        firstCol.Add (Int32.Parse (i, CultureInfo.InvariantCulture))
                        isFirst <- false
                    else
                        secondCol.Add (Int32.Parse (i, CultureInfo.InvariantCulture))

        firstCol, secondCol

    let part1 (input : string) =
        let firstCol, secondCol = getColumns input
        firstCol.Sort ()
        secondCol.Sort ()

        let mutable answer = 0

        for i = 0 to firstCol.Count - 1 do
            answer <- answer + abs (firstCol.[i] - secondCol.[i])

        answer

    let part2 (input : string) =
        let firstCol, secondCol = getColumns input
        let counts = Dictionary ()

        for i in secondCol do
            // why does .NET not give you access to a mutable entry like Rust does :sob:
            // double lookup here we come
            match counts.TryGetValue i with
            | false, _ -> counts.[i] <- 1
            | true, v -> counts.[i] <- v + 1

        let mutable result = 0

        for i = 0 to firstCol.Count - 1 do
            result <- result + firstCol.[i] * counts.GetValueOrDefault firstCol.[i]

        result
