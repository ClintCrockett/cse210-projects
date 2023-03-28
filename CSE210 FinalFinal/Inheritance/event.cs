using System;
// Austin Reeves

public class Event
{

    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    protected Address _address;


    public void getStandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date}\n{_time}\n{_address.fulladdress()}");
    }




}