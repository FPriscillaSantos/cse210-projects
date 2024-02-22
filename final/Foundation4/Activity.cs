class Activity
{
    protected float _minutes;

    public Activity(float minutes)
    {
        _minutes = minutes;
    }
    public virtual string GetSummary()
    {
        return "";
    }
    public virtual float GetSpeed() 
    {    
        return 0;
    }
    public virtual float GetDistance()
    {    
        return 0;
    }
    public virtual float GetPace() 
    {
        return 0;
    }

}