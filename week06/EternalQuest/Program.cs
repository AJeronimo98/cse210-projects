using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("🌟 Eternal Quest Goal Program 🌟");
            Console.WriteLine($"Your Score: {totalScore}");
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Plushie Shop");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            choice = Console.ReadLine();

            if (choice == "1")
                CreateGoal();
            else if (choice == "2")
                ListGoals();
            else if (choice == "3")
                RecordEvent();
            else if (choice == "4")
                OpenShop();
        }
    }

    static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times to complete? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new CheckListGoal(name, description,points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
        Console.ReadLine();
    }

    static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("Your Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            string status = goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {goals[i].GetDetails()}");
        }

        Console.ReadLine();
    }

    static void RecordEvent()
    {
        Console.Clear();
        ListGoals();

        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            totalScore += earned;

            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        Console.ReadLine();
    }

    static void OpenShop()
    {
        Console.Clear();
        Console.WriteLine("🧸 Welcome to the Plushie Shop 🧸");
        Console.WriteLine("1. Tiny Duck Plushie - 50 points");
        Console.WriteLine("2. Giant Panda Plushie - 100 points");
        Console.WriteLine("3. Dragon Plushie - 200 points");
        Console.WriteLine("4. Exit Shop");

        string choice = Console.ReadLine();

        if (choice == "1")
            BuyItem("Tiny Duck Plushie", 50);
        else if (choice == "2")
            BuyItem("Giant Panda Plushie", 100);
        else if (choice == "3")
            BuyItem("Dragon Plushie", 200);
    }

    static void BuyItem(string itemName, int cost)
    {
        if (totalScore >= cost)
        {
            totalScore -= cost;
            Console.WriteLine($"You bought {itemName}!");
        }
        else
        {
            Console.WriteLine("Not enough points 😭");
        }

        Console.ReadLine();
    }
}
