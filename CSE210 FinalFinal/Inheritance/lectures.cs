using System;
// Austin Reeves

public class Lectures : Event
{
    protected string _speakerName = "";
    protected int _capacity = 1;


    public void getFullDetails()
    {
        Console.WriteLine("");
        getStandardDetails();
        Console.WriteLine($"The speaker will be {_speakerName},\nthere can be up to {_capacity} participants.");
        Console.WriteLine("Full details ^^");
        Console.WriteLine("");
    }

    public void getShortDescription()
    {
        Console.WriteLine($"The event is a lecture, called {_title}, and is on {_date}");
    }

    public Lectures(){
        _address = new Address();
        Console.WriteLine("Event title");
        _title = Console.ReadLine();

        Console.WriteLine("Event description");
        _description = Console.ReadLine();

        Console.WriteLine("Event date");
        _date = Console.ReadLine();

        Console.WriteLine("Event time");
        _time = Console.ReadLine();

        Console.WriteLine("Speaker Name");
        _speakerName = Console.ReadLine();

        Console.WriteLine("Capacity Limit");
        _capacity = int.Parse(Console.ReadLine());
        
    }
}