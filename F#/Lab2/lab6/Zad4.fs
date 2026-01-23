open System

let rec readLines acc =
    let line = Console.ReadLine()
    if String.IsNullOrWhiteSpace line then List.rev acc
    else readLines (line :: acc)

let lines = readLines []

let formatLine line =
    let parts = line.Split(';')
    let firstName = parts.[0].Trim()
    let lastName = parts.[1].Trim()
    let age = parts.[2].Trim()
    sprintf "%s, %s (%s lat)" lastName firstName age

let formatted = lines |> List.map formatLine

formatted |> List.iter (printfn "%s")
