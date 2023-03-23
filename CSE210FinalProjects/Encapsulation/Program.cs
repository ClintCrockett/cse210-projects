using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the shipping program!");

        Address address = new Address
        {
            Street = "123 Main St",
            City = "Anytown",
            State = "CA",
            Country = "USA"
        };

        Customer customer = new Customer
        {
            Name = "John Smith",
            Address = address
        };

        Product product1 = new Product
        {
            Name = "Product 1",
            Id = 1,
            Price = 9.99f,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            Id = 2,
            Price = 19.99f,
            Quantity = 1
        };

        List<Product> products = new List<Product> { product1, product2 };

        Order order = new Order
        {
            Customer = customer,
            Products = products
        };

        order.ComputeTotalPrice();

        Display(order);
    }

    static void Display(Order order)
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nTotal Price: $" + order.TotalPrice);
    }
}
