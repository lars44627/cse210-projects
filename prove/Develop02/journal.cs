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
}