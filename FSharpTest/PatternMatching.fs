module PatternMatching

open System
open System.IO

let testvalue v = 
    match v with 
    | 1 -> true
    | 4 | 5 | 6 -> true
    | _ -> false

let fail = testvalue 10
let pass = testvalue 1

let isGreaterThanTen twoTuple = 
    match twoTuple with 
    | (x,_) when x > 10 -> true
    | (x,_) when x <= 10 && x > 0 -> false
    | (_,10) -> true
    | _ -> false

let rec fib n = 
    match n with 
    | 0 -> 0
    | 1 -> 1
    | _ -> fib(n-1) + fib(n-2)

let (|Even|Odd|) input = if input % 2 = 0 then Even else Odd
let TestNumber input = 
    match input with 
        | Even -> (printfn "%d is even" input)
        | Odd -> (printfn "%d is odd" input)

TestNumber 10

let keepIfPositive (a : int) = if a > 0 then Some(a) else None

let (|IsEven|_|) input = if input % 2 = 0 then Some() else None
let (|IsLessThan30|_|) input = if input < 30 then Some() else None

let checkNumber input = 
    match input with 
    | IsEven & IsLessThan30  -> printfn "Even and Less than 30"
    | IsEven -> printfn "Even"
    | _ -> printfn "No Match"
checkNumber 10

let (|MultipleOf|_|) x input = if input % x = 0 then Some(input/x) else None

let check input = 
    match input with
    | MultipleOf 3 input -> printfn "Multiple of 3"
    | _ -> printfn "Not Multiple of 3"

check 10

let checktype x = 
    match box x with 
    | :? System.Int32 -> printfn "It is an int 32"
    | :? System.String -> printfn "It is a string"
    | _ -> printfn "This is another type"

checktype 10

type MyRecord = { Name: string; ID: int }

let IsMatchByName record1 (name: string) = 
    match record1 with
    | { MyRecord.Name = nameFound; MyRecord.ID = _;} when nameFound = name -> true
    | _ -> false

let writetofile filename obj = 
    use file1 = File.CreateText(filename)
    file1.WriteLine("{0}", obj.ToString())
try
    writetofile "FileIOTest.txt" "Testing FSharp"
with
    | :? System.IO.FileLoadException -> printfn "Error writing to file"

printfn "Fibonacci of 10: %d" (fib 10)
let waiting = Console.ReadLine()