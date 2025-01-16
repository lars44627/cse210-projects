using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        int num = 0;
        List<int> numbers = new List<int>();

        do{
        Console.WriteLine("Enter a number to add it to the list, enter 0 to end");
        string input = Console.ReadLine();
        num = int.Parse(input);
        if (num != 0)
        {
            numbers.Add(num);
        }

        }while (num != 0);


        int highest = 0;
        int total = 0;
        foreach(int n in numbers)
        {
            total += n;
            if(n > highest)
            {
            highest = n;
            }
        }
        Console.WriteLine($"Sum Total: {total}");

        int count = numbers.Count;
        double avg = numbers.Average();
        Console.WriteLine($"Average: {avg}");

        Console.WriteLine($"Highest Number: {highest}");


    }
}