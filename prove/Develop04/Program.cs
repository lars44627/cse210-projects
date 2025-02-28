//My above an beyond is having a number next to each activity showing how many times it has been run

using System;

class Program
{
    private int breathingCount = 0;
    private int reflectionCount = 0;
    private int listingCount = 0;

    public Program()
    {
        while (true)
        {
        Menu();
        string choice = Console.ReadLine();
        
        if (choice == "4") return;
            if (choice == "1")
            {
                breathingCount++;
                new BreathingActivity().Start();
            }
            else if (choice == "2")
            {
                reflectionCount++;
                new ReflectionActivity().Start();
            }
            else if (choice == "3")
            {
                listingCount++;
                new ListingActivity().Start();
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
    }
}
    public void Menu()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine($"1. Breathing Activity (run {breathingCount} times)");
        Console.WriteLine($"2. Reflection Activity (run {reflectionCount} times)");
        Console.WriteLine($"3. Listing Activity (run {listingCount} times)");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }
    public static void Main()
    {
        new Program();
    }
}