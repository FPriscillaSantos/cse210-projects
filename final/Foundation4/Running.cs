class Running : Activity
{
    protected float _distance;
    protected float _speed;

    public Running(float distance, float minutes, float speed) 
        : base(minutes)
    {
        _distance = distance;
        _speed = speed;
    }
    public override float GetSpeed()
    {    
        return _distance / _minutes;
    }
    public override float GetDistance()
    {    
        return _distance;
    }
    public override float GetPace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"* {DateTime.Now:dd MMM yyyy} Running ({_minutes:F1} min) - Distance {_distance:F1} miles, Speed {_speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}