using System;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    public static void AddScore(int points)
    {
        score += points;
    }

    static void Main()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("\nEternal Quest Tracker");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save & Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "1") CreateGoal();
            else if (choice == "2") RecordEvent();
            else if (choice == "3") ShowGoals();
            else if (choice == "4") Console.WriteLine($"Current Score: {score}");
            else if (choice == "5") { SaveGoals(); return; }
            else Console.WriteLine("Invalid choice, try again.");
        }
    }