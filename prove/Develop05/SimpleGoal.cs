using System;

class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            Program.AddScore(Points);
        }
    }

    public override string Display() => (_isCompleted ? "[X] " : "[ ] ") + Name;

    public override string SaveFormat() => $"Simple,{Name},{Points},{_isCompleted}";
}