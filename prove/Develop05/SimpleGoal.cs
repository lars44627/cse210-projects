public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, int points) : base(name, points) // ✅ Calls Goal constructor
    {
        _completed = false;
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
