//how many times activities were performed.
//Added another animation (TwistedEffec)
using System;
using System.Threading;

class Program
{
    
    private static int _userOption = 0;
    static void Main(string[] args)
    {
        int _activityCount = 0;
        while (_userOption !=4)
        {
            Console.Clear();
            Console.Write("Menu Options: \r\n  1. Start breathing activity \r\n  2. Start reflecting activity \r\n  3. Start listing activity \r\n  4. Quit \r\nSelect a choice from the menu: ");
            _userOption = Convert.ToInt32(Console.ReadLine());

        
            if (_userOption == 1)
            {         
                new BreathingActivity().Start();
                _activityCount = _activityCount + 1;
            }

            else if (_userOption == 2)
            {
                new ReflectingActivity().Start();
                _activityCount = _activityCount + 1;
            }

            else if (_userOption == 3)
            {
                new ListingActivity().Start();
                _activityCount = _activityCount + 1;
            }

            else if (_userOption ==4)
            {
                break;
            }
        }
        if (_activityCount > 1)
        {
            Console.Write($"Congratulations! You've completed {_activityCount} activities!");
        }
        else
        {
            Console.Write("Congratulations! You've completed the activity!");
        }
    }

}