//Above and beyond was making a timed goal that has a due date

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    public static void AddScore(int points) => _score += points;

    static void Main()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("\nEternal Quest Tracker");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save & Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "1") CreateGoal();
            else if (choice == "2") RecordEvent();
            else if (choice == "3") ShowGoals();
            else if (choice == "4") Console.WriteLine($"Current Score: {_score}");
            else if (choice == "5") { SaveGoals(); return; }
            else Console.WriteLine("Invalid choice, try again.");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select Goal Type: 1. Simple 2. Eternal 3. Checklist 4. Timed");
        string type = Console.ReadLine();
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid input! Points must be a number.");
            return;
        }

        if (type == "1") _goals.Add(new SimpleGoal(name, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, points));
        else if (type == "3")
        {
            Console.Write("Enter Target Count: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid input! Target count must be a number.");
                return;
            }

            Console.Write("Enter Bonus Points: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid input! Bonus points must be a number.");
                return;
            }

            _goals.Add(new ChecklistGoal(name, points, target, bonus));
        }
        else if (type == "4")
        {
            Console.Write("Enter Number of Days to Complete: ");
            if (!int.TryParse(Console.ReadLine(), out int days))
            {
                Console.WriteLine("Invalid input! Days must be a number.");
                return;
            }
            _goals.Add(new TimedGoal(name, points, DateTime.Now.AddDays(days)));
        }
        else Console.WriteLine("Invalid option.");
        SaveGoals();
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter Goal Number to Record: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            _goals[index - 1].RecordEvent();
            SaveGoals();
            Console.WriteLine("Event Recorded!");
        }
        else Console.WriteLine("Invalid selection.");
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"[{i + 1}] {_goals[i].Display()}");
    }

    static void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score);
                _goals.ForEach(goal => writer.WriteLine(goal.SaveFormat()));
            }
            Console.WriteLine("Goals Saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        string[] lines = File.ReadAllLines("goals.txt");
        if (lines.Length == 0) return;

        _score = int.Parse(lines[0]);
        _goals.Clear();

        foreach (var line in lines[1..])
        {
            string[] parts = line.Split(',');
            string type = parts[0], name = parts[1];
            int points = int.Parse(parts[2]);

            if (type == "Simple")
            {
                bool completed = bool.Parse(parts[3]);
                var simpleGoal = new SimpleGoal(name, points);
                if (completed) simpleGoal.RecordEvent();
                _goals.Add(simpleGoal);
            }
            else if (type == "Eternal") _goals.Add(new EternalGoal(name, points));
            else if (type == "Checklist")
            {
                int target = int.Parse(parts[3]), bonus = int.Parse(parts[4]), timesCompleted = int.Parse(parts[5]);
                var checklistGoal = new ChecklistGoal(name, points, target, bonus);
                for (int i = 0; i < timesCompleted; i++) checklistGoal.RecordEvent();
                _goals.Add(checklistGoal);
            }
            else if (type == "Timed")
            {
                DateTime deadline = DateTime.Parse(parts[3]);
                bool completed = bool.Parse(parts[4]);
                var timedGoal = new TimedGoal(name, points, deadline);
                if (completed) timedGoal.RecordEvent();
                _goals.Add(timedGoal);
            }
        }
        Console.WriteLine("Goals Loaded!");
    }
}