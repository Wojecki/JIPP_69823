open System

let n = Console.ReadLine() |> int

let rec fib n =
    if n <= 1 then n
    else fib (n - 1) + fib (n - 2)

let fibTail n =
    let rec loop a b n =
        if n = 0 then a
        else loop b (a + b) (n - 1)
    loop 0 1 n

printfn "%d" (fib n)
printfn "%d" (fibTail n)
