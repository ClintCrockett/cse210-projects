// Jayton 
using System;

class Program
{
    static void Main(string[] args)
    {
        // create a variable that will access the jobs file
        Job job1 = new Job();
        // using our new variable we can access the file and pull our public variables
        job1._jobTitle = "Software Engineer";
        job1._comapny = "Mircosoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // same thing just a new job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._comapny = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // same thing but with resume
        Resume myResume = new Resume();
        // add in the users name
        myResume._name = "Jayton Crockett";
        // append the jobs to the list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}

