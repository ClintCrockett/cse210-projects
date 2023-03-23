using System;
using System.Collections.Generic;


public class Video
{
    private string AR_title = "";
    private string AR_actor = "";
    private int AR_length = 0;
    private List<Comment> comments = new List<Comment>();

    private List<string> videos = new List<string>();

    private List<string> titles = new List<string>(){

        "How to Prepare For a Wedding?",
        "10 Steps to Not Die of Stress",
        "3 Simple Ways to Get Good Grades"
    };
    private List<string> actors = new List<string>(){

        "Joseph Earl",
        "John Earl",
        "Marcus Reynolds"
    };

    private List<int> lengths = new List<int>(){

        10,
        8,
        30
    };

    public void videosMethod()
    {
        _title = titles[(new Random().Next(titles.Count))];
        _actor = actors[new Random().Next(actors.Count)];
        _length = lengths[new Random().Next(lengths.Count)];

        for (int i = 0; i < 4; i++)
        {
            Comment c = new Comment();
            c.comment();
            comments.Add(c);
        }
    }

    public int getCommentsQuantity()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"The video title is {_title}, which was made by {_actor}, the video is {_length} minutes long");
        Console.WriteLine($"There are {getCommentsQuantity()} comments");

        Console.WriteLine("Comments:");
        foreach (Comment c in comments)
        {
            c.Display();
        }
        Console.WriteLine("");
    }


}

