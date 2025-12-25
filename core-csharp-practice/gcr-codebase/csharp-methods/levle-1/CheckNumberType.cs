using System;

class CheckNumberType

{
    // Method 
    static int CheckNumber(int number)
    {
        if (number > 0) return 1; //
        if (number < 0) return -1;
        return 0;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); //take input from user 

        int result = CheckNumber(number); //call method

        Console.WriteLine("Result: " + result); //output
    }
}
