open System

let n =
    match Int32.TryParse(Console.ReadLine()) with
    | true, value -> value
    | false, _ -> 0

if n <= 0 then
    printfn "Błąd"
else
    let mutable suma = 0
    let mutable minimum = Int32.MaxValue
    let mutable maksimum = Int32.MinValue
    let mutable count = 0

    let rec readInt () =
        match Int32.TryParse(Console.ReadLine()) with
        | true, value -> value
        | false, _ -> readInt ()

    while count < n do
        let x = readInt ()
        suma <- suma + x
        if x < minimum then minimum <- x
        if x > maksimum then maksimum <- x
        count <- count + 1

    let srednia = float suma / float n

    printfn "%d" suma
    printfn "%f" srednia
    printfn "%d" minimum
    printfn "%d" maksimum
