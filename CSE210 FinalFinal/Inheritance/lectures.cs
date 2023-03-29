using System;
// Austin Reeves

public class Lectures : Event
{
    protected string AR_speakerName = "";
    protected int AR_capacity = 1;


    public void getFullDetails()
    {
        Console.WriteLine("");
        getStandardDetails();
        Console.WriteLine($"The speaker will be {AR_speakerName},\nthere can be up to {AR_capacity} participants.");
        Console.WriteLine("Full details ^^");
        Console.WriteLine("");
    }

    public void getShortDescription()
    {
        Console.WriteLine($"The event is a lecture, called {AR_title}, and is on {AR_date}");
    }

    public Lectures(){
        _address = new Address();
        Console.WriteLine("Event title");
        AR_title = Console.ReadLine();

        Console.WriteLine("Event description");
        AR_description = Console.ReadLine();

        Console.WriteLine("Event date");
        AR_date = Console.ReadLine();

        Console.WriteLine("Event time");
        AR_time = Console.ReadLine();

        Console.WriteLine("Speaker Name");
        AR_speakerName = Console.ReadLine();

        Console.WriteLine("Capacity Limit");
        AR_capacity = int.Parse(Console.ReadLine());
        
    }
}