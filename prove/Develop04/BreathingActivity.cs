using System;

class BreathingActivity : Activity
{
    protected override string GetDescription() { return "Breathe in and out with the timer. This should help you relax"; }
    protected override void Run()
    {
        for (int i = 0; i < _Duration / 6; i++)
        {
            Console.WriteLine("Breathe in..."); Pause(4);
            Console.WriteLine("Breathe out..."); Pause(4);
        }
    }
}