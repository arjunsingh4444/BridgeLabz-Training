using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //inout 

     
        int originalNumber = number;

        
        int sum = 0;

       
        while (number != 0) //loop 
        {
            // Get last digit
            int digit = number % 10;

            // Add cube of digit to sum
            sum += digit * digit * digit;

            // Remove last digit from numbe
            number = number / 10;
        }

       
        if (sum == originalNumber) //condition 
            Console.WriteLine("It is an Armstrong Number");
        else
            Console.WriteLine("It is NOT an Armstrong Number");
    }
}
