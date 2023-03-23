using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        // Product product = new Product("milk" , 120, (decimal) 3.12 , 2);
        // Address address = new Address("340 s 100 w", "Rexburg", "ID", "Canada");

        Address address1 = new Address("325 S 2nd St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Keanu Reeves", address1);
        List<Product> products1 = new List<Product>()
        {
            new Product("Pixel 8", "W321", 599.99, 3),
            new Product("Iphone 14", "G777", 999.99, 1)
        };
        Order order1 = new Order(products1, customer1);



        Address address2 = new Address("2330 NE 180th Ave", "Vancouver", "WA", "USA");
        Customer customer2 = new Customer("Austin Reeves", address2);
        List<Product> products2 = new List<Product>()
        {
            new Product("Mouse", "T888", 49.99, 2),
            new Product("Keyboard", "D872", 39.99, 1),
            new Product("Reeses Sticks", "W549", 5.99, 4)
        };
        Order order2 = new Order(products2,customer2);

        Console.WriteLine(order1.p_label());
        Console.WriteLine(order1.s_label());
        Console.WriteLine($"{order1.total():C}\n");

        Console.WriteLine(order2.p_label());
        Console.WriteLine(order2.s_label());
        Console.WriteLine($"{order2.total():C}\n");

        
        
    }
}

