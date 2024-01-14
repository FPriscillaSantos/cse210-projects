using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("3. C# Prep 3—Loops");

        Console.Write("Choose a number:  ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        Console.Write("Guess the number:  ");
        string userInput2 = Console.ReadLine();
        int guessNumber = int.Parse(userInput2);

        if (guessNumber > number)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNumber < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guessNumber == number)
        {
            Console.WriteLine("Correct!");
        }
    }
}