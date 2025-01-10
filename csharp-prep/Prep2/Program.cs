using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your number grade for the course?:");
        string grade = Console.ReadLine();
        int gradeN = int.Parse(grade);
        string letter = "";


        if (gradeN >= 90)
        {
            letter = "A";
        }
        else if (gradeN >= 80)
        {
            letter = "B";
        }
        else if (gradeN >= 70)
        {
            letter = "C";
        }
        else if (gradeN >= 60)
        {
            letter = "D";
        }
        else if (gradeN < 60)
        {
            letter = "F";
        }

        if (gradeN >= 70)
        {
            Console.WriteLine(" Congratulations! you passed");
        }
        else if (gradeN < 70)
        {
            Console.WriteLine("sorry, but you can get it next time!");
        }
        Console.WriteLine($"your letter grade: {letter}");
    }
}