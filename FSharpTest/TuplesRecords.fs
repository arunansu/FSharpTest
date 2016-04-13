module TuplesRecords

open System

let animal1 = ("Jack", "Dog", 1, 1229293)
let name, animaltype, age, id = animal1

type person = {name: string; mutable age: int}
let dave = {name = "Dave Russel"; age = 35}
printfn "Dave Name: %s" dave.name
dave.age <- dave.age + 1
printfn "Dave age: %d" dave.age
let readln = Console.ReadLine()