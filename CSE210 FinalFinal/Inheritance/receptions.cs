using System;
// Austin Reeves

public class Receptions : Event
{
    protected string AR_RSVPemail = "";

    public void getFullDetails()
    {
        Console.WriteLine("");
        getStandardDetails();
        Console.WriteLine($"The RSVP email is {AR_RSVPemail}");
        Console.WriteLine("Full details ^^");
        Console.WriteLine("");
    }


    public void getShortDescription()
    {
        Console.WriteLine($"The event is a Reception, called {AR_title}, and is on {AR_date}");
    }

    public Receptions()
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

        Console.WriteLine("RSVP email");
        AR_RSVPemail = Console.ReadLine();


    }

}