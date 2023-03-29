using System;

public class Running : Activity
{
    protected float _distance = 1;

    public Running()
    {
        _date = DateTime.Now;

        Console.WriteLine("How far did you run(miles) ");
        _distance = Convert.ToInt16(Console.ReadLine());

        _activityType = "Running";

        Console.WriteLine("How long did you run for?(minutes) ");
        _length = Convert.ToInt16(Console.ReadLine());

    }       

    public override float computeDistance()
    {
        return _distance;
    }
    public override float computeSpeed()
    {
        return _distance / _length * 60;
    }


}
