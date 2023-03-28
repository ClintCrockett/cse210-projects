using System;

public class Address
{

    private string AR_street_address;
    private string AR_city;
    private string AR_state;
    private string AR_country;

    public Address()
    {
        Console.WriteLine("What is your street address?");
        AR_street_address = Console.ReadLine();

        Console.WriteLine("What is your City?");
        AR_city = Console.ReadLine();

        Console.WriteLine("What is your State?");
        AR_state = Console.ReadLine();

        Console.WriteLine("What is your Country?");
        AR_country = Console.ReadLine();

    }

    public string fulladdress()
    {

        return $"{AR_street_address} {AR_city}, {AR_state} {AR_country}";
    }

}