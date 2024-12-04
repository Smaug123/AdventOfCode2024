namespace AdventOfCode2024

[<RequireQualifiedAccess>]
module Run =

    let mutable shouldWrite = true

    let day1 (partTwo : bool) (input : string) =
        if not partTwo then
            let output = Day1.part1 input

            if shouldWrite then
                printfn "%i" output
        else
            let output = Day1.part2 input

            if shouldWrite then
                printfn "%i" output