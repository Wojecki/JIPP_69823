open System

let text = Console.ReadLine()
let searchWord = Console.ReadLine()
let replaceWord = Console.ReadLine()

let words =
    text.Split([|' '|], StringSplitOptions.None)

let replaced =
    words
    |> Array.map (fun w -> if w = searchWord then replaceWord else w)
    |> String.concat " "

printfn "%s" replaced
