using System;
// Austin Reeves, Jacob Strong

public class Listening : Activity
{
    public Listening() : base()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
    }


    public void displayActivity()
    {
        Console.WriteLine(_description);
    }
}