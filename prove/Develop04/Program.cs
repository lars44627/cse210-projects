using System;

class Program
{
    public Program()
    {
        Menu();
        string choice = Console.ReadLine();
        
        if (choice == "4") return;
        if (choice == "1") new BreathingActivity().Start();
        else if (choice == "2") new ReflectionActivity().Start();
        else if (choice == "3") new ListingActivity().Start();
        else Console.WriteLine("Invalid choice, exiting program.");
    }

    public void Menu()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }
}