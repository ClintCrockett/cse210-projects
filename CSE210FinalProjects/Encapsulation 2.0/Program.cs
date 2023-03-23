using System;

namespace ShipmentCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product p1 = new Product("T-shirt", 123, 15.0f, 2);
            Product p2 = new Product("Jeans", 456, 50.0f, 1);
            Product p3 = new Product("Sneakers", 789, 80.0f, 1);

            // Create a customer
            Address a1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer c1 = new Customer("John Smith", a1);

            // Create an order with the products and customer
            Order o1 = new Order(c1);
            o1.AddProduct(p1);
            o1.AddProduct(p2);

            // Print the packing label and shipping label
            Console.WriteLine(o1.GetPackingLabel());
            Console.WriteLine(o1.GetShippingLabel());

            // Calculate and print the total price
            Console.WriteLine("Total Price: $" + o1.ComputeTotalPrice());

            // Create another order with different products and customer
            Address a2 = new Address("456 Elm St", "Anytown", "CA", "USA");
            Customer c2 = new Customer("Jane Doe", a2);

            Order o2 = new Order(c2);
            o2.AddProduct(p2);
            o2.AddProduct(p3);

            // Print the packing label and shipping label
            Console.WriteLine(o2.GetPackingLabel());
            Console.WriteLine(o2.GetShippingLabel());

            // Calculate and print the total price
            Console.WriteLine("Total Price: $" + o2.ComputeTotalPrice());
        }
    }
}
