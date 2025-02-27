using System;

class Program
{
    static void Main()
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Division");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Division", "5.1", "1-20");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Samuel Bennett", "History", "The Renaissance");
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}