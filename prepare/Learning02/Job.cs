using System;

class Job{
    // As you create public variables, which can be used in other files,
    // you can either add emply values or nothing but you always set it to 
    // string, int, or any other value.
    public string _comapny;
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear = 0000;
    
    // Display is a function is a function that is used like a print
    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_comapny}) {_startYear}-{_endYear}");
    }
}