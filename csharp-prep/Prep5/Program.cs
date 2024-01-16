using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        //Console.WriteLine("5. C# Prep 5—Functions");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquare = SquareNumber(userNumber);
        string display = DisplayResult(userName,userSquare);
        
        Console.Write($"{display} ");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberChosen = Console.ReadLine();
        int number = int.Parse(numberChosen);
        return number;
    }

    static int SquareNumber(int intNumber)
    {
        int square = intNumber * intNumber;
        return square;
    }

    static string DisplayResult (string userName, int userSquare)
    {
        string finalDisplay = $"{userName}, the square of your number is {userSquare}";
        return finalDisplay;
    }
}