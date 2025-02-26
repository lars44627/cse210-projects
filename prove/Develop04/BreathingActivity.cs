using System;

class BreathingActivity : Activity
{
    protected string GetDescription() { return "Breathe in and out with the timer. This should help you relax"; }
    protected void Run()
    {
        for (int i = 0; i < _Duration / 6; i++)
        {
            Console.WriteLine("Breathe in..."); Pause(3);
            Console.WriteLine("Breathe out..."); Pause(3);
        }
    }
}