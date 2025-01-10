using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your first name?:");
        string name = Console.ReadLine();
        Console.Write("Your last name?:");
        string name2 = Console.ReadLine();
        Console.WriteLine($"your name is {name2}, {name} {name2}");
    }
}