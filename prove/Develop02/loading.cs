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