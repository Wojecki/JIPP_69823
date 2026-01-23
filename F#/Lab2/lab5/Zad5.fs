open System

let rec quickSort list =
    match list with
    | [] -> []
    | pivot :: rest ->
        let smaller = rest |> List.filter (fun x -> x <= pivot)
        let greater = rest |> List.filter (fun x -> x > pivot)
        quickSort smaller @ [pivot] @ quickSort greater

let quickSortIter list =
    let mutable stack = [list]
    let mutable result = []

    while stack <> [] do
        match stack with
        | [] -> ()
        | [] :: rest ->
            stack <- rest
        | [x] :: rest ->
            result <- x :: result
            stack <- rest
        | lst :: rest ->
            let pivot = List.head lst
            let tail = List.tail lst
            let smaller = tail |> List.filter (fun x -> x <= pivot)
            let greater = tail |> List.filter (fun x -> x > pivot)
            stack <- smaller :: [pivot] :: greater :: rest

    List.rev result


let numbers = [5; 3; 8; 1; 2]

printfn "%A" (quickSort numbers)
printfn "%A" (quickSortIter numbers)
