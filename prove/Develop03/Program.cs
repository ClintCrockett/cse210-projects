using System;

using System;

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

            // Create a new Scripture object with the specified reference
            Scripture scripture = new Scripture(reference);

            // Display the scripture text
            Console.WriteLine(scripture.scriptureString());
        }
    }
}