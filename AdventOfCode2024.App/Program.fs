namespace AdventOfCode2024

open System.IO

module Program =
    let inline input (folder : DirectoryInfo) (day : int) : string =
        Path.Combine (folder.FullName, $"day%i{day}.txt") |> File.ReadAllText

    [<EntryPoint>]
    let main argv =
        let inputFolder = argv.[0] |> DirectoryInfo

        do
            let input = input inputFolder 1
            Run.day1 true input

        0
