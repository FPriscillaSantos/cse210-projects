public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        name = _shortName;
        description = _description;
        points = _points;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailString()
    {
        return $"{_shortName}: {_description} - {_points} points"; //falta coisa
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points"; //falta coisa
    }
}