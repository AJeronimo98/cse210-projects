/* CREATIVITY AND EXCEEDING REQUIREMENTS:
    1. Strict File Organization: Every class is in its own file named exactly after the class, 
       ensuring 100% adherence to the Style and Abstraction requirements.
    2. Input Validation: Added logic to handle user input for durations and menu choices 
       to prevent program crashes.
    3. Enhanced Spinner: The spinner animation uses a modular approach in the base class 
       so it can be easily adjusted across all activities from one location.
*/



using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }
    }
}