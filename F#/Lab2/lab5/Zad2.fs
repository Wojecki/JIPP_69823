type Tree =
    | Empty
    | Node of int * Tree * Tree

let tree =
    Node(10,
        Node(5,
            Node(3, Empty, Empty),
            Node(7, Empty, Empty)),
        Node(15,
            Empty,
            Node(20, Empty, Empty))
    )

let rec contains value tree =
    match tree with
    | Empty -> false
    | Node(v, l, r) ->
        v = value || contains value l || contains value r

let containsIter value tree =
    let rec loop stack =
        match stack with
        | [] -> false
        | Empty :: rest -> loop rest
        | Node(v, l, r) :: rest ->
            if v = value then true
            else loop (l :: r :: rest)
    loop [tree]

printfn "%b" (contains 7 tree)
printfn "%b" (containsIter 7 tree)
