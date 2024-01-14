using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("3. C# Prep 3—Loops");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guessNumber;
        
        do
        {            
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guessNumber = int.Parse(userInput2);

            if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
        } while (guessNumber != number);
        
        Console.WriteLine("You guessed it!");
        
    }
}