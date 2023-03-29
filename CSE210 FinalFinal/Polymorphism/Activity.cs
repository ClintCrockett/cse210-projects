using System;

public abstract class Activity
{

    protected DateTime _date;
    protected int _length = 1;
    protected string _activityType = "";
    protected float _pace = 1;


    public abstract float computeDistance();

    public abstract float computeSpeed();

    public float computePace()
    {
        return _length / computeDistance();
    }

    public virtual void getSummary()
    {
        Console.WriteLine($"{_date} - {_activityType} For {_length} Minutes - Distance: {computeDistance()} Miles - {computeSpeed()} MPH - {computePace()} Minutes per mile avg pace");
    }


}
