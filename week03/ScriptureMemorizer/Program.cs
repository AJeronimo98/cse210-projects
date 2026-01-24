using System;

namespace ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength.")
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string input = "";

        while (input.ToLower() != "quit")
        {
            Console.Clear(); 
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end:");
            
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            if (input == "") 
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}