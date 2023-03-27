using System;
// Austin Reeves

public class Lectures : Event
{
    protected string _speakerName = "";
    protected int _capacity = 1;


    public void getFullDetails()
    {
        Console.WriteLine($"{_title}/n {_description}/n {_date}/n {_time}/n {_address} /n {_speakerName} /n {_capacity}");
    }

    public void getShortDescription()
    {
        Console.WriteLine($"The event is a lecture, its title is {_title}, and is on {_date}");
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