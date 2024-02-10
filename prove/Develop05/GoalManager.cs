using System.IO; 
public class GoalManager
{
    public List<Goal> _goals;
    public int score;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }    

    public void ListGoalDetails()
    {

    } 

    public void CreateGoal()
    {
        Console.Write("What is the filename for the goal? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
         } 

    public void RecordEvent()
    {

    } 

    public void SaveGoals()
    {

    } 

    public void LoadGoals()
    {

    } 
}