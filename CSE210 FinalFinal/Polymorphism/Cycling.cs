using System;

public class Cycling : Activity {

    protected float _speed = 1;

    public Cycling(){

        _date = DateTime.Now;

        Console.WriteLine("How fast did you bike?(mph) ");
        _speed = Convert.ToInt16(Console.ReadLine());

        _activityType = "Cycling";

        Console.WriteLine("How long did you cycle for?(minutes) ");
        _length = Convert.ToInt16(Console.ReadLine());

    }

    public override float computeDistance(){
        return _speed / 60 * _length;
    }
    public override float computeSpeed(){
        return _speed;
    }

}
