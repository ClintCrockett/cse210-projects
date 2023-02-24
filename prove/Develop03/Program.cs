using System;

// Austin Reeves

class Program
{
    static void Main(string[] args)
    {
        string userResponse = "0";
        while (userResponse != "quit")
        {
            Console.WriteLine("Welcome to the scripture hiding app!");
            Console.Write("Enter a scripture reference (e.g. John 3:16): ");
            string reference = Console.ReadLine();

            // Create a new Scripture class with the reference
            Scripture scripture = new Scripture(reference);

    
            Console.WriteLine(scripture.scriptureString());
        }
    }
}