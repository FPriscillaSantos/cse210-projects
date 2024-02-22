class Swimming : Activity
{
    protected float _laps;
    
    public Swimming(float laps, float minutes, float speed) 
        : base(minutes)
    {
       _laps = laps;
    }
    public override float GetSpeed()
    {    
        return (GetDistance() / _minutes) * 60;
    }
    public override float GetDistance()
    {    
        return _laps * 50 / 1000;
    }
    public override float GetPace()
    {
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"* {DateTime.Now:dd MMM yyyy} Swimming ({_minutes:F1} min) - Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}