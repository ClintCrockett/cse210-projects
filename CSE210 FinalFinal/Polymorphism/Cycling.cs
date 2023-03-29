using System;

public class Cycling : Activity {

    protected float AR_speed = 1;

    public Cycling(){

        AR_date = DateTime.Now;

        Console.WriteLine("How fast did you bike?(mph) ");
        AR_speed = Convert.ToInt16(Console.ReadLine());

        AR_activityType = "Cycling";

        Console.WriteLine("How long did you cycle for?(minutes) ");
        AR_length = Convert.ToInt16(Console.ReadLine());

    }

    public override float computeDistance(){
        return AR_speed / 60 * AR_length;
    }
    public override float computeSpeed(){
        return AR_speed;
    }

}
