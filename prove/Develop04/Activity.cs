using System;
class Activity
{
    protected int _Duration;

    public void Start()
    {
        Console.WriteLine(GetDescription());
        Console.Write("Enter duration: ");
        _Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(3);
        Run();
        Console.WriteLine($"Good job! You did {_Duration} seconds.");
        Pause(3);
    }

    protected virtual void Run() {}
    protected virtual string GetDescription() { return "Activity"; }
    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}