open System

let text = Console.ReadLine()

let words =
    text.Split([|' '|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.length

let characters =
    text
    |> Seq.filter (fun c -> c <> ' ')
    |> Seq.length

printfn "%d" words
printfn "%d" characters
