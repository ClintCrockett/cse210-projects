using System;
// Austin Reeves

public class OutdoorGatherings : Event
{
    protected string AR_weatherForecast = "";


    public void getFullDetails()
    {
        Console.WriteLine("");
        getStandardDetails();
        Console.WriteLine($"The weather will be {AR_weatherForecast}");
        Console.WriteLine("Full details ^^");
        Console.WriteLine("");
    }


    public void getShortDescription()
    {
        Console.WriteLine($"The event is an Outdoor Gathering, called {AR_title}, and is on {AR_date}");
    }


    public OutdoorGatherings()
    {
        _address = new Address();
        Console.WriteLine("Event title");
        AR_title = Console.ReadLine();

        Console.WriteLine("Event description");
        AR_description = Console.ReadLine();

        Console.WriteLine("Event date");
        AR_date = Console.ReadLine();

        Console.WriteLine("Event time");
        AR_time = Console.ReadLine();

        Console.WriteLine("Weather Forecast");
        AR_weatherForecast = Console.ReadLine();


    }
}   