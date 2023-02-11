using System;

class Program
{
    static void Main(string[] args)
    {
        string userResponse = "0";
        while (userResponse != "quit")
        {
            Console.WriteLine("Welcome to the scripture hiding app! ");
            Console.Write("Press enter to continue, or type quit to stop ");
            userResponse = Console.ReadLine();

        }
    }
}