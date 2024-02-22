class Cycling : Activity
{
    protected float _speed;

    public Cycling(float distance, float minutes, float speed) 
        : base(minutes)
    {
        _speed = speed;
    }
    public override float GetSpeed()
    {    
        return _speed;
    }
    public override float GetDistance()
    {    
        return _speed * _minutes;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"* {DateTime.Now:dd MMM yyyy} Cycling ({_minutes:F1} min) - Distance {GetDistance():F1} miles, Speed: {_speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}