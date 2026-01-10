using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Pedir el porcentaje al usuario
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        // 2. Determinar la letra (Core Requirement 1 y 3)
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 3. Imprimir la letra una sola vez
        Console.WriteLine($"Your grade is: {letter}");
        
        // 4. Determinar si pasó o no (Core Requirement 2)
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do better next time.");
        }
    }
}