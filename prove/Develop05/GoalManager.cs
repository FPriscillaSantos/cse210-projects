using System.IO; 
public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: \r\n  1. Create New Goal \r\n  2. List Goals \r\n  3. Save Goals \r\n  4. Load Goals \r\n  5. Record Event \r\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            Console.WriteLine("");
            switch (menuChoice) 
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Please choose a valid option. ");
                    break;
            }
        }
    }

    public void ListGoals()
    {
        foreach (var goal in _goals) {
            Console.WriteLine((goal.IsComplete() ? "[X] " : "[ ] ") + goal.GetDetailsString());
        }
        Console.WriteLine("");
    }   

    public void CreateGoal()
    {
        Console.Write("The types of Goals are: \r\n  1. Simple Goal \r\n  2. Eternal Goal \r\n  3. Checklist Goal \r\nWhich type of goal would you like to create? ");
        string typeGoal = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of point associated with this goal? ");
        string _amountPoints = Console.ReadLine();
        int amountPoints = int.Parse(_amountPoints);
        
        switch (typeGoal) 
        {
            case "1": //simple
                _goals.Add(new SimpleGoal(shortName, description, amountPoints));
                break;

            case "2": //eternal
                _goals.Add(new EternalGoal(shortName, description,amountPoints));
                break;

            case "3": //checklist
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for acomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(shortName, description, amountPoints, target, bonus));
                break;

            default:
                Console.WriteLine("Please choose a valid option. ");
                break;
        }
    }
 

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.Write("Enter the number corresponding to the goal: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            selectedGoal.RecordEvent();
            if (!selectedGoal.IsComplete())
            {
                _score += selectedGoal._points; 
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal? ");
        string fileName = Console.ReadLine();

        int totalPoints = _score;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            //string color = "Blue";
            //outputFile.WriteLine($"My favorite color is {color}");
            
            foreach (var goal in _goals) 
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to '{fileName}'.");
        Console.WriteLine("");
    } 

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        _goals.Clear();
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            // Ignora a primeira linha que contém o total de pontos
            string totalPointsLine = inputFile.ReadLine();
            
            // Pula para a segunda linha, onde os objetivos começam
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(shortName, description, points));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(shortName, description, points));
                        break;
                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {type}");
                        break;
                }
            }

            Console.WriteLine("Goals loaded from 'goals.txt'.");
            Console.WriteLine("");
        }
    }
} 
