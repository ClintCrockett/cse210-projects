using System;
// Austin Reeves

public class Activity
{
    private string _startingMessage = "Welcome to the activity!!";
    private int _prompt = -1;
    private string _name = "";
    private string _description = "";
    private string _finishingMessage  = "Thanks for playing the activity!";


    public Activity(string _name, string _description, int _prompt)
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        _name = name;

        Console.WriteLine(" ");
        string description = Console.ReadLine();
        _description = description;

        Console.WriteLine("How long would you like to perform the activity for? (In seconds)");
        string userInput = Console.ReadLine();
        int prompt = int.Parse(userInput);
        _prompt = prompt;

    }
    
}