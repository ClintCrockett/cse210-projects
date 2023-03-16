using System;

// Authors: Austin Reeves
// 
// The main program shows the menu, has a list containing all the goals, and prompts the user which menu option they would like to perform
// 
// 

class Program
{
    static void Main(string[] args)
    {
        List<goals> goal = new List<goals>();


        int userResponse = -1;
        while (userResponse != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1: Create New Goal");
            Console.WriteLine("  2: List Goals");
            Console.WriteLine("  3: Save Goals");
            Console.WriteLine("  4: Load Goals");
            Console.WriteLine("  5: Record Event");
            Console.WriteLine("  6: Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            userResponse = int.Parse(userInput);


            if (userResponse == 1)
            {
                int goalType = -1;
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("  1: Simple Goal");
                Console.WriteLine("  2: Eternal Goal");
                Console.WriteLine("  3: Checklist Goal ");

                Console.Write("What type of goal would you like to create? ");
                string chosenGoal = Console.ReadLine();
                goalType = int.Parse(chosenGoal);

                if (goalType == 1)
                {
                    string goalName = "";
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();

                    string goalDescription = "";
                    Console.Write("What is a short description of your goal? ");
                    goalDescription = Console.ReadLine();
           
                }

                if (goalType == 2)
                {
                    string goalName = "";
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();

                    string goalDescription = "";
                    Console.Write("What is a short description of your goal? ");
                    goalDescription = Console.ReadLine();
                }

                if (goalType == 3)
                {
                    string goalName = "";
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();

                    string goalDescription = "";
                    Console.Write("What is a short description of your goal? ");
                    goalDescription = Console.ReadLine();
                }
            }



        }
    }
}