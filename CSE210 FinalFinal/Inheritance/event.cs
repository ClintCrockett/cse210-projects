using System;
// Austin Reeves

public class Event
{

    protected string AR_title = "";
    protected string AR_description = "";
    protected string AR_date = "";
    protected string AR_time = "";
    protected Address _address;


    public void getStandardDetails()
    {
        Console.WriteLine($"{AR_title}\n{AR_description}\n{AR_date}\n{AR_time}\n{_address.fulladdress()}");
    }




}