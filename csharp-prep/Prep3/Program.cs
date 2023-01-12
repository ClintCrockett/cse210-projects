// Name: Jayton Crockett
// Date: Jan 10, 2023

using System;

class Program
{
    static void Main(string[] args)
    {
        // changing the functions into a variable so it is more useable
        int magic = Get_magic_number();
        
        int guess = Get_user_number();
        
        // count the number of guesses
        int count = 1;

        while (guess != magic){
            // prints lower or higher depeneding on the input
            Display_higher(magic, guess);
            
            Display_lower(magic, guess);
            
            // asks the user for the number
            guess = Get_user_number();
            
            // count
            count += 1;
        }
        // Correct answer
        Display_correct(magic, guess);
        Display_count(count);
    }
    
    static int Get_magic_number(){
        Random rand_int = new Random();
        int magic = rand_int.Next(1, 100);
        return magic;
    }
    
    static int Get_user_number(){
        Console.WriteLine("What is your guess? ");
        string user_guess = Console.ReadLine();
        int guess = int.Parse(user_guess);
        return guess;
    }
    static void Display_higher(int magic, int guess){
        if (magic > guess){
            Console.WriteLine("Higher");
        }
    }
    static void Display_lower(int magic, int guess){
        if (magic < guess){
            Console.WriteLine("Lower");
        }    }
    static void Display_correct(int magic, int guess){
        Console.WriteLine($"{guess} is correct! The magic number was {magic}");
    }
    static void Display_count(int count){
        if (count == 1){
            Console.WriteLine($"Woah, great job! It only took you {count} guess!");
        }
        else if ((count >= 2) && (count <= 11))
            Console.WriteLine($"Nice job! It took you {count} guesses.");
        else {
            Console.WriteLine($"It took you {count} guesses.");
        }
    }
    static void Get_playagain(string[] args){
        Console.WriteLine("Would you like to play again?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "yes"){
            Main(args);
        }
        else{
            Console.WriteLine("Thank you for playing!");
        }
    }

}
