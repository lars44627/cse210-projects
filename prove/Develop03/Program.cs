using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int choice = random.Next(2);

        Reference reference;
        Scripture scripture;

        if (choice == 0)
        {
        reference = new Reference("Proverbs", 3, 5, 6);
        scripture = new Scripture(reference, "Trust in the LORD with all thine heart: and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        }
        else
        {
        reference = new Reference("John", 3, 16);
        scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }

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
