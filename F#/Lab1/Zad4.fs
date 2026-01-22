type Student = {
    Name: string
    Age: int
    Grade: float
}

let students = [
    { Name = "Anna"; Age = 20; Grade = 4.5 }
    { Name = "Bartek"; Age = 22; Grade = 3.8 }
    { Name = "Celina"; Age = 21; Grade = 4.0 }
    { Name = "Dawid"; Age = 23; Grade = 2.9 }
]

let goodStudents =
    students
    |> List.filter (fun s -> s.Grade >= 4.0)

let olderStudents =
    students
    |> List.map (fun s -> { s with Age = s.Age + 1 })

printfn "%A" goodStudents
printfn "%A" olderStudents
