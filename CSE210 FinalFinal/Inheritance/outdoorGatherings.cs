using System;
// Austin Reeves

public class OutdoorGatherings : Event
{
    protected string _weatherForecast = "";


    public void getFullDetails()
    {
        Console.WriteLine($"{_title}/n {_description}/n {_date}/n {_time}/n {_address} /n {_weatherForecast}");
    }

    public void getShortDescription()
    {
        Console.WriteLine($"The event is an Outdoor Gathering, its title is {_title}, and is on {_date}");
    }


    public OutdoorGatherings()
    {
        _address = new Address();
        Console.WriteLine("Event title");
        _title = Console.ReadLine();

        Console.WriteLine("Event description");
        _description = Console.ReadLine();

        Console.WriteLine("Event date");
        _date = Console.ReadLine();

        Console.WriteLine("Event time");
        _time = Console.ReadLine();

        Console.WriteLine("Weather Forecast");
        _weatherForecast = Console.ReadLine();


    }
}   