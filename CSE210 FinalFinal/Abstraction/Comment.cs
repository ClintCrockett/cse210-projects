using System;


public class Comment
{

    private string AR_userName = "";

    private string AR_comment = "";


    private List<string> usernames = new List<string>(){

        "Efrain Gomez",
        "Austin Reeves",
        "Dallin Hipps"
    };
    private List<string> comments = new List<string>(){

        "Wow, he's super good at C#",
        "By chance are you going to get married soon",
        "Dang you're super amazing"
    };

    public void comment()
    {
        _userName = usernames[(new Random().Next(usernames.Count))];
        _comment = comments[new Random().Next(comments.Count)];
    }

    public void Display()
    {
        Console.WriteLine($"A comment by {_userName} says {_comment}");
    }
}