using System;

class Program
{
    static void Main()
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Division");
        Console.WriteLine(assignment.GetSummary());
    }
}