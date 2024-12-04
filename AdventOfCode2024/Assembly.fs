namespace AdventOfCode2024

open System
open System.IO
open System.Reflection

[<RequireQualifiedAccess>]
module Assembly =

    let readResource (asm : Assembly) (name : string) : string =
        let name =
            asm.GetManifestResourceNames ()
            |> Seq.filter (fun n -> n.EndsWith (name, StringComparison.OrdinalIgnoreCase))
            |> Seq.exactlyOne

        use stream = asm.GetManifestResourceStream name

        use reader = new StreamReader (stream)
        reader.ReadToEnd ()
