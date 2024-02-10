using System;
using System.IO; 
class Program
{
    public static int _totalPoints = 0;
    static void Main(string[] args)
    
    {
        do
        {
            Console.WriteLine($"You have {_totalPoints} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: \r\n  1. Create New Goal \r\n  2. List Goals \r\n  3. Save Goals \r\n  4. Load Goals \r\n  5. Record Event \r\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("The types of Goals are: \r\n  1. Simple Goal \r\n  2. Eternal Goal \r\n  3. Checklist Goal \r\nWhich type of goal would you like to create? ");
            string typeGoal = Console.ReadLine();
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of point associated with this goal? ");
            string _amountPoints = Console.ReadLine();
            int amountPoints = int.Parse(_amountPoints);

            if (menuChoice == "1")
            {
                GoalManager.CreateGoal();
            }

            if (menuChoice == "2")
            {
                Goal.GetDetailsString();
            }

            if (menuChoice == "3")
            {
                GoalManager.SaveGoals();
            }

            if (menuChoice == "4")
            {
                GoalManager.LoadGoals();
            }

            if (menuChoice == "5")
            {
                GoalManager.RecordEvent();
            }

            if (menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4" && menuChoice != "5" && menuChoice != "6")
            {
                Console.Write("Please choose a valid option. ");
            } 
        } while (menuChoice != "6");
    }
}