using System;

class Resume
{
    // make your variables
    public string _name;
    // create your variable that is a list 
    public List<Job> _jobs = new List<Job>();

    // again we display what we want
    public void Display(){
        // display the name of the persons resume
        Console.WriteLine($"Name: {_name}");
        // display all the jobs they apply for 
        Console.WriteLine("Jobs:");
        // for loop that runs through all jobs and prints them
        foreach(Job job in _jobs){
            job.Display();
        }
    }
}
