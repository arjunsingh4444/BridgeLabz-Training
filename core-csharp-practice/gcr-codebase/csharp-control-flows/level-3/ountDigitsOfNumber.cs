using System;

class CountDigitsOfNumber
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //take input 

        int count = 0;

      
        while (number != 0) //loop 
        {
            // Remove last digit
            number = number / 10;

            
            count++;
        }

        
        Console.WriteLine("Number of digits is "+count);
    }
}
