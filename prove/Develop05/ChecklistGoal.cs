using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _count = 0;

    public ChecklistGoal(string name, int points, int target, int bonus)
    {
        Name = name;
        Points = points;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _count++;
        Program.AddScore(Points);

        if (_count >= _target)
        {
            Program.AddScore(_bonus);
            Console.WriteLine($"Checklist Goal '{Name}' completed! Bonus Points Awarded.");
        }
        else Console.WriteLine($"Checklist Goal '{Name}' recorded. {_target - _count} left.");
    }

    public override string Display() => $"{Name} - Completed {_count}/{_target} times";
    public override string SaveFormat() => $"Checklist,{Name},{Points},{_target},{_bonus},{_count}";
}
