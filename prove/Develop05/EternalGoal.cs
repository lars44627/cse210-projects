public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Program.AddScore(Points);
        Console.WriteLine($"Goal '{Name}' recorded. Keep going!");
    }

    public override string Display() => $"{Name} (Eternal)";
    public override string SaveFormat() => $"Eternal,{Name},{Points}";
}
