let rec permutations list =
    match list with
    | [] -> [ [] ]
    | _ ->
        list
        |> List.collect (fun x ->
            let rest = List.filter ((<>) x) list
            permutations rest
            |> List.map (fun p -> x :: p)
        )

let numbers = [1; 2; 3]

let result = permutations numbers

printfn "%A" result
