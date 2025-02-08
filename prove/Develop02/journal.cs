//Second Class: Journal with Entry list
public class Journal
{
    public string _Title;
    public string _DateCreated;
    public List<Entry> _Entry = new List<Entry>();

    //Method for showing entries
    public void ShowEntries()
    {
        if (_Entry.Count > 0)
        {
            foreach (var entry in _Entry)
            {
                Console.WriteLine(entry.FormatEntry());
            }
        }
        else
        {
            Console.WriteLine($"Sorry, There are no current entries");
        }
    }

    //Method for Journal display
    public void WriteEntry(DisplayPrompt promptGenerator)
    {
        Console.WriteLine("Date?:");
        string date = Console.ReadLine();
        string prompt = promptGenerator.GetRandom();

        Console.WriteLine($"{prompt}:");
        string content = Console.ReadLine();

        Entry newEntry = new Entry()
        {
            _Content = content,
            _Date = date,
            _Prompt = prompt
        };
        _Entry.Add(newEntry);
    }
}