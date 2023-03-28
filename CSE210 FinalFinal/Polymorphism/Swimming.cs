using System;

public class Swimming : Activity
{

    protected float _laps = 1;


    public Swimming()
    {
        _date = DateTime.Now;

        Console.WriteLine("How many laps did you swim? ");
        _laps = Convert.ToInt16(Console.ReadLine());

        _activityType = "Swimming";

        Console.WriteLine("How long did you swim for?(minutes) ");
        _length = Convert.ToInt16(Console.ReadLine());

    }

    public override float computeDistance()
    {
        return _laps * 50 / 1000 * 0.62f;
    }
    public override float computeSpeed()
    {
        return computeDistance() / _length * 60;
    }


}
