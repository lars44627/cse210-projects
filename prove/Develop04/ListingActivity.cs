using System;

class ListingActivity : Activity
{
    string[] _prompts = { "List people you appreciate.", "List your strengths." };
    protected override string GetDescription() { return "List as many positive things as you can."; }
    protected override void Run()
    {
        Console.WriteLine(_prompts[new Random().Next(_prompts.Length)]);
        Pause(1);
        int count = 0;
        Console.WriteLine("Start listing items (press enter after each):");
        for (int elapsed = 0; elapsed < _Duration; elapsed += 3)
        {
            if (!string.IsNullOrWhiteSpace(Console.ReadLine())) count++;
        }
        Console.WriteLine($"You listed {count} items!");
    }
}