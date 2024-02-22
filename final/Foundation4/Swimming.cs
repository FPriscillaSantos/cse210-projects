class Swimming : Actvity
{
    protected float _laps;
    
    public Swimming(float distance, float speed, float pace) 
        : base(distance, speed, pace)
    {
       _laps = 0;
    }
    public override void GetSpeed(float speed) 
    {    
        speed = (GetDistance / minutes) * 60
    }
    public override void GetDistance(float distance)
    {    
        distance = _laps * 50 / 1000;
    }
    public override void GetPace(float pace) 
    {
        pace = 60 / speed;
    }
}