public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
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
        return $"{_shortName}: {_description} - {_points} points";
    }
}