using System;
// Austin Reeves

public class OutdoorGatherings : Event
{
    protected string _weatherForecast = "";


    public void getFullDetails()
    {
        Console.WriteLine("");
        getStandardDetails();
        Console.WriteLine($"The weather will be {_weatherForecast}");
        Console.WriteLine("Full details ^^");
        Console.WriteLine("");
    }


    public void getShortDescription()
    {
        Console.WriteLine($"The event is an Outdoor Gathering, called {_title}, and is on {_date}");
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