open System

let numbers =
    Console.ReadLine().Split(' ')
    |> Array.map int
    |> Array.toList

let dodatnie =
    numbers
    |> List.filter (fun x -> x > 0)
    |> List.length

let kwadraty =
    numbers
    |> List.map (fun x -> x * x)

let suma =
    numbers
    |> List.fold (fun acc x -> acc + x) 0

printfn "%d" dodatnie
printfn "%A" kwadraty
printfn "%d" suma
