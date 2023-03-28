using System;
// Austin Reeves

public class Receptions : Event
{
    protected string _RSVPemail = "";

    public void getFullDetails()
    {
        Console.WriteLine("");
        getStandardDetails();
        Console.WriteLine($"The RSVP email is {_RSVPemail}");
        Console.WriteLine("Full details ^^");
        Console.WriteLine("");
    }


    public void getShortDescription()
    {
        Console.WriteLine($"The event is a Reception, called {_title}, and is on {_date}");
    }

    public Receptions()
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

        Console.WriteLine("RSVP email");
        _RSVPemail = Console.ReadLine();


    }

}