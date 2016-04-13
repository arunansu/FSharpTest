module ListTest

open System

let array = [|1;2;3|]
printfn "First element of array is %d" (array.[0])
let array0to2 = array.[0..2]
let arraybefore2 = array.[..2]
let arrayafter0 = array.[0..]
let arraydynamic = [|for i in 1..10 -> i|]
for i in arraydynamic do
    printf "%d " i
printfn ""
let sumarray = 
    let mutable c = 0
    for i in 0..arraydynamic.Length - 1 do
        c <- c + arraydynamic.[i]
    printfn "Sum of array is %d" c
    c

let list = [1;2;3]
let listdots = [2..9]
let listappend = list@listdots
let list0append = 0::list

let listtest = 
    let testlist = [for i in 1 .. 10 -> i + i]
    for i in testlist do
        printf "%d " i
    printfn ""
    printfn "Head: %d" testlist.Head
    let taillist = testlist.Tail
    printfn "IsEmpty: %s" (testlist.IsEmpty.ToString())
    printfn "Tail List First Item: %d" (taillist.Item(0))

let seqa = seq { 0 .. 2 .. 10} //Creates sequence of multiples of 2 
let seqb = seq { for i in 1 .. 10 do yield i * i } 
let seqc = seq { for i in 1 .. 10 -> i * i }
let printseq = 
    for i in seqa do
        printf "%d " i //Sequences are evaluated as they are accessed
    Console.ReadLine()
