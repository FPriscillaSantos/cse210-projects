using System.Diagnostics;

class Actvity
{
    protected float _distance;
    protected float _speed;
    protected float _pace;

    public Activity(float distance, float speed, float pace)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public void GetSummary()
    {

    }

    public virtual void GetSpeed(float speed) 
    {    
    }
    public virtual void GetDistance(float distance)
    {    
    }
    public virtual void GetPace(float pace) 
    {
    }

}
