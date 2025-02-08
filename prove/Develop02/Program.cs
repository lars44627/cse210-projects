using System;
using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

//My above and beyond was adding a method that lets the user do a custom prompt.
//The prompt is saved with the entry, but not in the code
//This ended up covering more than I thought. Initial console displayed.
class Program
{
    static void Main(string[] args)
    {
        int Direction = 0;
        Journal myJournal = new Journal();
        DisplayPrompt promptGenerator = new DisplayPrompt();

        while(Direction != 5)
        {
        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1: Show Journal Entries");
        Console.WriteLine("2: Write a New Entry");
        Console.WriteLine("3: Save Journal to File");
        Console.WriteLine("4: Load Journal from file");
        Console.WriteLine("5: quit application");
        Console.WriteLine("6: Add prompt");

        string Directionin = Console.ReadLine();
        Direction = int.Parse(Directionin);

//Direction handling
        if (Direction == 1)
            {
                myJournal.ShowEntries();
            }
        else if (Direction == 2)
            {
                myJournal.WriteEntry(promptGenerator);
            }
        else if (Direction == 3)
            {
                SaveTextFromFile.SaveJournal(myJournal);
                Console.WriteLine("Journal Saved");
            }
        else if (Direction == 4)
            {
                LoadTextFromFile.LoadJournal(myJournal);
                Console.WriteLine("Journal Loaded");
            }
        else if (Direction == 5)
            {
                Console.WriteLine("quitting application");
            }
        else if (Direction == 6)
            {
                promptGenerator.AddPrompt();
            }
        }
    }
}
