using System;

class Program
{
    private static int _userOption = 0;
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Menu Options: \r\n  1. Start breathing activity \r\n  2. Start reflecting activity \r\n  3. Start listing activity \r\n  4. Quit \r\nSelect a choice from the menu: ");
        _userOption = Convert.ToInt32(Console.ReadLine());
    
        if (_userOption == 1)
        {
            Console.Clear();
            Console.Write("Welcome to the Breathing Activity. \r\n \r\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. \r\nHow long, in seconds, would you like for your session? ");
            int _seconds = Convert.ToInt32(Console.ReadLine());
        }

        else if (_userOption == 2)
        {
            Console.Clear();
            Console.Write("Welcome to the Reflecting Activity. \r\n \r\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. \r\nHow long, in seconds, would you like for your session? ");
            int _seconds = Convert.ToInt32(Console.ReadLine());
        }

        else if (_userOption == 3)
        {
            Console.Clear();
            Console.Write("Welcome to the Listing Activity. \r\n \r\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \r\nHow long, in seconds, would you like for your session? ");
            int _seconds = Convert.ToInt32(Console.ReadLine());
        }

        else if (_userOption !=1 && _userOption !=2 && _userOption !=3 && _userOption !=4)
        {
            Console.Write("Invalid option");
        }

    }

}