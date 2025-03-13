using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent()
    {
        Program.AddScore(Points);
        Console.WriteLine($"Goal '{Name}' recorded. Keep going!");
    }

    public override string Display() => $"{Name} (Eternal)";
    public override string SaveFormat() => $"Eternal,{Name},{Points}";
}
