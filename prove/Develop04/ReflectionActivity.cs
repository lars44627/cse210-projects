using System;

class ReflectionActivity : Activity
{
    string[] _prompts = { "Think of a time when you stood up for someone else",
                            "Think of a time when you did something really difficult",
                            "Think of a time when you helped someone in need",
                            "Think of a time when you did something truly selfless." };
    string[] _questions = { "Why was this experience meaningful to you?",
                            "Have you ever done anything like this before?",
                            "How did you get started?",
                            "How did you feel when it was complete?" };

    protected override string GetDescription() { return "Reflect on past experiences to recognize your strength."; }
    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
        Pause(2);
        int elapsed = 0;
        while (elapsed < _Duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Length)]);
            Pause(5);
            elapsed += 5;
        }
    }
}