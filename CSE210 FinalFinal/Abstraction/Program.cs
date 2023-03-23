using System;


class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>()
        {
            new Video(),
            new Video(),
            new Video(),
            new Video()
        };

        foreach (Video v in videos)
        {
            v.videosMethod();
            v.Display();
        }

    }
}
