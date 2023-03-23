using System;

public class comment
{

    private string userName = "";

    private string comment = "";


    private List<string> usernames = new List<string>(){

        "Efrain Gomez",
        "Austin Reeves",
        "Dallin Hipps"
    };
    private List<string> comments = new List<string>(){

        "He's super good at C#",
        "Is going to get married soon",
        "Is super amazing"
    };

    public comment(){
        userName = usernames[(new Random().Next(usernames.Count))];
        comment = comments[new Random().Next(comments.Count)];
    }

    public void Display(){
        Console.WriteLine($"The username is {userName} and their comment is {comment}");
    }
}