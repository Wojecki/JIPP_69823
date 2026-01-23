open System

let text = Console.ReadLine()

let words =
    text.Split([|' '|], StringSplitOptions.RemoveEmptyEntries)

let longestWord =
    words |> Array.maxBy (fun w -> w.Length)

printfn "%s" longestWord
printfn "%d" longestWord.Length
