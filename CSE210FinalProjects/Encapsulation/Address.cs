using System;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public void Display()
    {
        Console.WriteLine("Address: " + FullAddress());
    }

    public string FullAddress()
    {
        return Street + ", " + City + ", " + State + ", " + Country;
    }
}
