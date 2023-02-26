using System;
// Austin Reeves, Jacob Strong

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
        DateTime end_time = DateTime.Now;
        end_time = end_time.AddSeconds(_duration);
        DateTime now = DateTime.Now;
        while(now < end_time){
            Console.WriteLine("Breathe in...");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("And breathe out");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            now = DateTime.Now;
        }
        Console.WriteLine(_finishingMessage);
        Console.WriteLine("You did the breathing activity for "+_duration+" seconds");
    }

}