
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