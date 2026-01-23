open System

let text = Console.ReadLine()

let isPalindrome s =
    let chars = s.ToCharArray()
    chars = Array.rev chars

if isPalindrome text then
    printfn "TAK"
else
    printfn "NIE"