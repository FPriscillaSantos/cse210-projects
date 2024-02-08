public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
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

    public string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points"; //falta coisa
    }
}