using System;

public abstract class Activity
{

    protected DateTime AR_date;
    protected int AR_length = 1;
    protected string AR_activityType = "";
    protected float AR_pace = 1;


    public abstract float computeDistance();

    public abstract float computeSpeed();

    public float computePace()
    {
        return AR_length / computeDistance();
    }

    public virtual void getSummary()
    {
        Console.WriteLine($"{AR_date} - {AR_activityType} For {AR_length} Minutes - Distance: {computeDistance()} Miles - {computeSpeed()} MPH - {computePace()} Minutes per mile avg pace");
    }


}
