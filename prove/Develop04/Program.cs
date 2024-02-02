using System;

class Program
{
    private static int _userOption = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: \r\n  1. Start breathing activity \r\n  2. Start reflecting activity \r\n  3. Start listing activity \r\n  4. Quit \r\nSelect a choice from the menu");
        _userOption = Convert.ToInt32(Console.ReadLine());
    
        if (_userOption == 1)
        {
            Console.WriteLine("Welcome to the Breathing Activity. \r\n \r\n This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. \r\nHow long, in seconds, would you like for your session?");
        }
    }

}