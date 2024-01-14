using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("2. C# Prep 2—Conditionals:");

        Console.Write("What was your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter;

        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";
        }

        else if (number >= 60)
        {
            letter =  "D";
        }

        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("I'm sorry, the grade wasn't enough. Try again next semester.");
        }
    }
}