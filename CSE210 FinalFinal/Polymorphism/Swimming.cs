using System;

public class Swimming : Activity
{

    protected float AR_laps = 1;


    public Swimming()
    {
        AR_date = DateTime.Now;

        Console.WriteLine("How many laps did you swim? ");
        AR_laps = Convert.ToInt16(Console.ReadLine());

        AR_activityType = "Swimming";

        Console.WriteLine("How long did you swim for?(minutes) ");
        AR_length = Convert.ToInt16(Console.ReadLine());

    }

    public override float computeDistance()
    {
        return AR_laps * 50 / 1000 * 0.62f;
    }
    public override float computeSpeed()
    {
        return computeDistance() / AR_length * 60;
    }


}
