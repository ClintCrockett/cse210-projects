using System;

public class Running : Activity
{
    protected float AR_distance = 1;

    public Running()
    {
        AR_date = DateTime.Now;

        Console.WriteLine("How far did you run(miles) ");
        AR_distance = Convert.ToInt16(Console.ReadLine());

        AR_activityType = "Running";

        Console.WriteLine("How long did you run for?(minutes) ");
        AR_length = Convert.ToInt16(Console.ReadLine());

    }       

    public override float computeDistance()
    {
        return AR_distance;
    }
    public override float computeSpeed()
    {
        return AR_distance / AR_length * 60;
    }


}
