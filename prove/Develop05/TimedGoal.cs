using System;

public class TimedGoal : Goal
{
    private DateTime _deadline;
    private bool _completed = false;

    public TimedGoal(string name, int points, DateTime deadline)
    {
        Name = name;
        Points = points;
        _deadline = deadline;
    }

    public override void RecordEvent()
    {
        if (!_completed && DateTime.Now <= _deadline)
        {
            _completed = true;
            Program.AddScore(Points);
            Console.WriteLine($"Goal '{Name}' completed before the deadline!");
        }
        else Console.WriteLine("Deadline has passed or goal already completed.");
    }

    public override string Display() => _completed ? $"{Name} (Completed)" : $"{Name} - Due by {_deadline:MM/dd/yyyy}";
    public override string SaveFormat() => $"Timed,{Name},{Points},{_deadline},{_completed}";
}
