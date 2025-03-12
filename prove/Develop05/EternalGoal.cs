using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent() => Program.AddScore(Points);

    public override string Display() => "[∞] " + Name;

    public override string SaveFormat() => $"Eternal,{Name},{Points}";
}