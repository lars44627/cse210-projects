using System;

class Program
{
    static void Main()
    {
        Square square = new Square("Red", 5);
        Console.WriteLine("Color: " + square.GetColor());
        Console.WriteLine("Area: " + square.GetArea());
    }
}