using System;

public class TimedGoal : Goal
{
    private DateTime _deadline;
    private bool _completed;

    public TimedGoal(string name, int points, DateTime deadline) : base(name, points)
    {
        _deadline = deadline;
        _completed = false;
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