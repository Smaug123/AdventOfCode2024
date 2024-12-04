namespace AdventOfCode2024

open System
open System.Globalization

[<RequireQualifiedAccess>]
module Day2 =
    let getRows (input : string) =
        let lines = input.AsSpan().Split '\n'
        let rows = ResizeArray ()

        for line in lines do
            let line =
                input.AsSpan().Slice (line.Start.Value, line.End.Value - line.Start.Value)

            if not line.IsEmpty then
                let row = ResizeArray ()

                for i in line.Split ' ' do
                    let i = line.Slice (i.Start.Value, i.End.Value - i.Start.Value)

                    row.Add (Int32.Parse (i, CultureInfo.InvariantCulture))

                rows.Add row

        rows

    let isSafe (indexToIgnore : int voption) (row : int ResizeArray) : bool =
        if row.Count <= 1 + (if indexToIgnore.IsSome then 1 else 0) then
            true
        else

        let mutable prev = row.[0 + if indexToIgnore = ValueSome 0 then 1 else 0]
        let mutable isOk = true

        let mutable i =
            match indexToIgnore with
            | ValueNone -> 1
            | ValueSome j -> 1 + if j < 2 then 1 else 0

        let mutable decreasing = prev >= row.[i]

        while isOk && i < row.Count do
            if indexToIgnore <> ValueSome i then
                let curr = row.[i]

                if decreasing then
                    match curr - prev with
                    | -1
                    | -2
                    | -3 -> ()
                    | _ -> isOk <- false
                else
                    match curr - prev with
                    | 1
                    | 2
                    | 3 -> ()
                    | _ -> isOk <- false

                prev <- curr

            i <- i + 1

        isOk

    let part1 (input : string) =
        let rows = getRows input

        let mutable result = 0

        for row in rows do
            if isSafe ValueNone row then
                result <- result + 1

        result

    let part2 (input : string) =
        let rows = getRows input

        let mutable result = 0

        for row in rows do
            if isSafe ValueNone row then
                result <- result + 1
            else

            let mutable toIgnore = 0
            let mutable isRowSafe = false

            while not isRowSafe && toIgnore <= row.Count do
                if isSafe (ValueSome toIgnore) row then
                    isRowSafe <- true

                toIgnore <- toIgnore + 1

            if isRowSafe then
                result <- result + 1

        result
