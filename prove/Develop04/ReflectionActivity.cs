using System;

class ReflectionActivity : Activity
{
    string[] _prompts = { "Think of a time you stood up for someone.", "Think of a time you overcame a challenge." };
    string[] _questions = { "Why was this meaningful?", "How did you feel after?" };

    protected override string GetDescription() { return "Reflect on past experiences to recognize your strength."; }
    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
        Pause(3);
        int elapsed = 0;
        while (elapsed < _Duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Length)]);
            Pause(5);
            elapsed += 5;
        }
    }
}