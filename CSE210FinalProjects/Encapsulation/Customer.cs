using System;


public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Address.Display();
    }
}
