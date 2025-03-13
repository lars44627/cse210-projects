using System;

public class SimpleGoal : Goal
{
    private bool _completed = false;

    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            Program.AddScore(Points);
            Console.WriteLine($"Goal '{Name}' completed!");
        }
        else Console.WriteLine("Goal already completed.");
    }

    public override string Display() => _completed ? $"{Name} (Completed)" : Name;
    public override string SaveFormat() => $"Simple,{Name},{Points},{_completed}";
}
