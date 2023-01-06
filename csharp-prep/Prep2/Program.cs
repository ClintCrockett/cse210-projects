using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percent? ");
        string answer = Console.ReadLine();
        double percent = int.Parse(answer);
        
        string value = "";

        if (percent >= 90){
            if (percent <= 93){
                value += "A";
            }
            else{
                value += "A-";
            }
            Console.Write($"You currently have an {value} in the class.");
        }
        else if (percent >= 80){
            if (percent >= 87){
                value += "B+";
            }
            else if (percent >= 83){
                value += "B";
            }
            else{
                value += "B-";
            }
            Console.Write($"You currently have a {value}");
        }
        else if (percent >= 70){
            if (percent >= 77){
                value += "C+";
            }
            else if (percent >= 73){
                value += "C";
            }
            else{
                value += "C-";
            }
            Console.Write($"You currently have a {value}");
        }
        else{
            value += "F";
            Console.Write($"You currently have a {value}");
        }
    }
}
