using System;
// Austin Reeves

public class Breathing : Activity
{
    public Breathing() : base()
    {

        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        // series of messages alternating between breathe in and breathe out, pausing for several seconds imbetween and showing a countdown, continuing till the prompt variable duration is finished
    }

    public void displayActivity()
    {
        Console.WriteLine(_description);
    }

}