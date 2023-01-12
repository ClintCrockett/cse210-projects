using System;

class Program
{
    static void Main(string[] args){
        // task for user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // list to keep all numbers list by user
        List<int> numbers = new List<int>();

        // grabs users number
        int user_num = Get_user_number();
        while (user_num != 0){
            // appends the number to list
            numbers.Add(user_num);
            // asks user again until 0
            user_num = Get_user_number();
        }
    
        Console.WriteLine($"The sum is: {Get_sum(numbers)}");
        Console.WriteLine($"The average is: {Get_average(numbers)}");
        Console.WriteLine($"The largest number is: {Get_largest_num(numbers)}");
        if (Get_smallest_pnum(numbers) == 99999){
            Console.WriteLine($"The smallest positive number is not found because there is no number above 0.");
        }
        else {
            Console.WriteLine($"The smallest positive number is: {Get_smallest_pnum(numbers)}");

        }
        // Console.WriteLine($"The sorted list is: {Get_sorted_list(numbers)}");




    }
    static int Get_user_number(){
        // asks user for a number
        Console.WriteLine("Enter number: ");
        // converts answer from string to number
        int num = int.Parse(Console.ReadLine());
        // returns number
        return num;
    }
    static int Get_sum(List<int> numbers){
        // create a variable we can add all numbers too
        int sum = 0;
        // for loop that runs through each number in the list
        foreach (var i in numbers){
            // adds each number to our sum variable
            sum += i;
        }
        return sum;
    }
    static int Get_average(List<int> numbers){
        // create two variables one that adds the numbers and
        // the other that counts each number
        int sum = 0;
        int count = 0;
        // for loop
        foreach (var i in numbers){
            // adds numbers
            sum += i;
            // counts numbers
            count += 1;
        }
        // calculates the average
        int avg = sum / count;
        return avg;
    }
    static int Get_largest_num(List<int> numbers){
        // new variable that we are compare our listed numbers
        // starting with -999 because users can input negatives
        int large_num = -99999;

        foreach (var i in numbers){
            if (i > large_num){
                large_num = i;
            }
        }
        return large_num;
    }
    static int Get_smallest_pnum(List<int> numbers){
        int smallest_pnum = 99999;

        foreach (var i in numbers){
            if (i < smallest_pnum && i > 0){
                smallest_pnum = i;
            }
        }
        
        return smallest_pnum;
    }
    // static void Get_sorted_list(List<int> numbers){
    //     numbers.Sort();
    // }
}
