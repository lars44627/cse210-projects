using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress 'enter' to hide words or type 'quit' to exit The Program.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideWords();

            if (scripture.IsFullyHidden())
            {
                scripture.Display();
                Console.WriteLine("\ngood Job on memorizing it!");
                break;
            }
        }
    }
}
