using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private Random _random = new Random();

    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void Run()
    {
        string option = "";

        while (option != "5")
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            option = Console.ReadLine();

            if (option == "1")
                WriteEntry();
            else if (option == "2")
                DisplayJournal();
            else if (option == "3")
                SaveJournal();
            else if (option == "4")
                LoadJournal();
        }
    }

    private void WriteEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry.Date = DateTime.Now.ToShortDateString();
        entry.Prompt = prompt;
        entry.Response = response;

        _entries.Add(entry);
    }

    private void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
        }
    }

    private void SaveJournal()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved.");
    }

    private void LoadJournal()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry.Date = parts[0];
            entry.Prompt = parts[1];
            entry.Response = parts[2];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded.");
    }
}