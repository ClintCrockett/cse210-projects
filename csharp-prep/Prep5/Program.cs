// Name: Jayton Crockett
// Date: Jan 11, 2023
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string user_name = PromptUserName();
        
        int user_num = PromptUserNumber();

        int squr_num = SquareNumber(user_num);
        DisplayResult(user_name, user_num, squr_num);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number:");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int user_num){
        int sqr_number = user_num * user_num;
        return sqr_number;
    }
    static void DisplayResult(string user_name, int user_num, int squr_num){
        Console.WriteLine($"{user_name}, the square of your favorite number({user_num}) is {squr_num}.");
    }
    
}
