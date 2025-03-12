using System;

class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus)
    {
        Name = name;
        Points = points;
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        Program.AddScore(Points);
        if (_timesCompleted == _target)
        {
            Program.AddScore(_bonus);
        }
    }

    public override string Display() => (_timesCompleted >= _target ? "[X] " : "[ ] ") + $"{Name} (Completed {_timesCompleted}/{_target})";

    public override string SaveFormat() => $"Checklist,{Name},{Points},{_target},{_bonus},{_timesCompleted}";
}