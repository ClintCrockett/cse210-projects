using System;
// Austin Reeves, Jacob Strong

public class Listening : Activity
{
    public Listening() : base()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
    }


    protected List<string> main_prompt = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected List<string> answer = new List<string>{

    };


    public void displayActivity()
    {
        Console.WriteLine(_description);

        Random random = new Random();
        int prompt_index = random.Next(0, 5);
        Console.WriteLine(main_prompt[prompt_index]);
        Console.WriteLine("After 10 seconds to think about the prompt, begin typing out your answers!");


        DateTime end_time = DateTime.Now;
        end_time = end_time.AddSeconds(10);
        DateTime now = DateTime.Now;
        while (now < end_time)
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");

            // All the code above is unfinished, I started copying some of Jacobs code from the Reflection.cs and editing it to match this activity then ran out of time

        Console.WriteLine("You can start listing answers! ");


        Console.WriteLine("You did the listening activity for " + _duration + " seconds");
    }
    
}