public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    private bool _isComplete;
    
    public ChecklistGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false; 
    }

    public void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public string GetDetailString()
    {
        return $"{_shortName}: {_description} - {_points} points"; //falta coisa
    }

    public string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points"; //falta coisa
    }
}