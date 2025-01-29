using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        int Direction = 0;
        while(Direction != 5)
        {
        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1: Show Journal Entries");
        Console.WriteLine("2: Write a New Entry");
        Console.WriteLine("3: Save Journal to File");
        Console.WriteLine("4: Load Journal from file");
        Console.WriteLine("5: quit application");
        string Directionin = Console.ReadLine();
        Direction = int.Parse(Directionin);
        }
    }
}

public class Entry
{
    public string _Content;
    public string _Date;
    public string _Prompt;
    public string FormatEntry()
    {
         return ($"Date:{_Date}, Prompt:{_Prompt}, Content:{_Content}");
    }
}

public class Journal
{
    public string _Title;
    public string _DateCreated;
    public string _EntryCollection;
    public List<Entry> _Entry = new List<Entry>();
}

public class DisplayPrompt
{

}

public class SaveTextFromFile
{

}

public class LoadTextFromFile
{

}