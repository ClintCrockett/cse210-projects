// Name: Jayton Crockett
// Date: Jan 6, 2023
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        double fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        Console.Write($"Your name {lname}, {lname} {fname}");
    }
}
