open System

let words =
    Console.ReadLine().Split(' ')
    |> Array.toList

let removeDuplicates list =
    let rec loop seen rest =
        match rest with
        | [] -> List.rev seen
        | x :: xs ->
            if List.contains x seen then
                loop seen xs
            else
                loop (x :: seen) xs
    loop [] list

let uniqueWords = removeDuplicates words

printfn "%A" uniqueWords
