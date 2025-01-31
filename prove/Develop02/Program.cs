using System;
using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;


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
                ShowEntries(myJournal);
            }
        else if (Direction == 2)
            {
                WriteEntry(myJournal, promptGenerator);
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
//Method for showing entries
    static void ShowEntries(Journal journal)
    {
        if (journal._Entry.Count > 0)
        {
            foreach (var entry in journal._Entry)
            {
                Console.WriteLine(entry.FormatEntry());
            }
        }
        else if (journal._Entry.Count == 0)
        {
            Console.WriteLine($"Sorry, There are no current entries");
        }
    }
//Method for Journal display
    static void WriteEntry(Journal journal, DisplayPrompt promptGenerator)
    {
        string content;
        Console.WriteLine("Date?:");
        string date = Console.ReadLine();
        string prompt = promptGenerator.GetRandom();

        Console.WriteLine($"{prompt}:");
        content = Console.ReadLine();

        Entry newEntry = new Entry()
        {
            _Content = content,
            _Date = date,
            _Prompt = prompt
        };
        journal._Entry.Add(newEntry);
    }

}
//First Class: Entry info stored
public class Entry
{
    public string _Content;
    public string _Date;
    public string _Prompt;
    public string FormatEntry()
    {
         return ($"Date:{_Date}, Prompt:{_Prompt}, Entry:{_Content}");
    }
}

//Second Class: Journal with Entry list
public class Journal
{
    public string _Title;
    public string _DateCreated;
    public List<Entry> _Entry = new List<Entry>();
}

//Display prompt and function
public class DisplayPrompt
{
    private List<string> _prompts = new List<string>
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandom()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void AddPrompt()
    {
        Console.WriteLine("Enter a new prompt to add:");
        string NewPrompt = Console.ReadLine();
        _prompts.Add(NewPrompt);
        Console.WriteLine("New prompt added successfully!");
    }
}

//Saving Class
public class SaveTextFromFile
{
    public static void SaveJournal(Journal journal)
    {
        Console.WriteLine("Name your file");
        string InputName = Console.ReadLine();
        string filepath = InputName;

        using (StreamWriter writer = new StreamWriter(filepath))
        { 
            foreach (var entry in journal._Entry)
            {
                writer.WriteLine($"{entry._Date}|{entry._Prompt}|{entry._Content}");
            }
        }
    }
}

//Loading Class(assuming text.file is there) to specified loacation
public class LoadTextFromFile
{
    public static void LoadJournal(Journal journal)
    {

        Console.WriteLine("What File do you Want to read?:");
        string InputName = Console.ReadLine();
        string filepath = InputName;

        using (StreamReader reader = new StreamReader(filepath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string content = parts[2];

                    Entry entry = new Entry() { _Date = date, _Prompt = prompt, _Content = content};
                    journal._Entry.Add(entry);
                }
            }
        }
    }
}