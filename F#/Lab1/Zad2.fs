open System

let aInput = Console.ReadLine()
let bInput = Console.ReadLine()

let a = int aInput
let b = int bInput

let mutable start = a
let mutable stop = b

if start > stop then
    let temp = start
    start <- stop
    stop <- temp

let mutable parzyste = 0
let mutable nieparzyste = 0
let mutable ujemne = 0
let mutable zera = 0
let mutable dodatnie = 0
let mutable podzielnePrzez3 = 0

let mutable i = start

while i <= stop do
    let parity =
        if i % 2 = 0 then
            parzyste <- parzyste + 1
            "parzysta"
        else
            nieparzyste <- nieparzyste + 1
            "nieparzysta"

    let sign =
        if i < 0 then
            ujemne <- ujemne + 1
            "ujemna"
        elif i = 0 then
            zera <- zera + 1
            "zero"
        else
            dodatnie <- dodatnie + 1
            "dodatnia"

    let divisibleBy3 =
        if i % 3 = 0 then
            podzielnePrzez3 <- podzielnePrzez3 + 1
            "tak"
        else
            "nie"

    printfn "%d: %s, %s, podzielna przez 3? %s" i parity sign divisibleBy3

    i <- i + 1

printfn "PODSUMOWANIE:"
printfn "Parzyste: %d" parzyste
printfn "Nieparzyste: %d" nieparzyste
printfn "Ujemne: %d" ujemne
printfn "Zero: %d" zera
printfn "Dodatnie: %d" dodatnie
printfn "Podzielne przez 3: %d" podzielnePrzez3
