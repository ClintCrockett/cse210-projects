using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percent? ");
        string answer = Console.ReadLine();
        double percent = int.Parse(answer);
        
        string letter = "";

        if (percent >= 90){
            if (percent <= 93){
                letter += "A";
            }
            else{
                letter += "A-";
            }
            Console.Write($"You currently have an {letter} in the class.");
        }
        else if (percent >= 80){
            if (percent >= 87){
                letter += "B+";
            }
            else if (percent >= 83){
                letter += "B";
            }
            else{
                letter += "B-";
            }
            Console.Write($"You currently have a {letter}");
        }
        else if (percent >= 70){
            if (percent >= 77){
                letter += "C+";
            }
            else if (percent >= 73){
                letter += "C";
            }
            else{
                letter += "C-";
            }
            Console.Write($"You currently have a {letter}");
        }
        else{
            letter += "F";
            Console.Write($"You currently have a {letter}");
        }
        if (percent >= 70){
            Console.Write($"\nYou passed!");
        }
        else {
            Console.Write($"\nSorry but you did not pass.");
        }
        
    }
}
