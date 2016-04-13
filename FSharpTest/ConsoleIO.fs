module ConsoleIO

open System

    let ConsoleTest = 
        Console.Write("Enter length of rectangle: ")
        let length = Console.ReadLine()
        let length = float length
        Console.Write("Enter width of rectangle: ")
        let width = Console.ReadLine()
        let width = float width
        let area = length * width
        Console.WriteLine("Area of rectangle is: " + area.ToString())
        Console.ReadLine()