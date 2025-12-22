using System;

class HarshadNumber
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //input 

        int originalNumber = number;
        int sum = 0;

        // Loop to calculate sum of digits takern by user I/P
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }

        // Check Harshad condition
        if (originalNumber % sum == 0)
            Console.WriteLine("It is a Harshad Number");
        else
            Console.WriteLine("It is NOT a Harshad Number");
    }
}
