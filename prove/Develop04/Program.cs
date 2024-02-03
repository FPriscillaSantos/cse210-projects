using System;
using System.Threading;

class Program
{
    private static int _userOption = 0;
    static void Main(string[] args)
    {
        while (_userOption !=4)
        {
            Console.Clear();
            Console.Write("Menu Options: \r\n  1. Start breathing activity \r\n  2. Start reflecting activity \r\n  3. Start listing activity \r\n  4. Quit \r\nSelect a choice from the menu: ");
            _userOption = Convert.ToInt32(Console.ReadLine());

        
            if (_userOption == 1)
            {         
                //BreathingActivity();
            }

            else if (_userOption == 2)
            {
                //ReflectingActivity();
            }

            else if (_userOption == 3)
            {
                ////ListingActivity();
            }

            else if (_userOption !=1 && _userOption !=2 && _userOption !=3 && _userOption !=4)
            {
                Console.Write("Invalid option");
            }
        }

    }

}