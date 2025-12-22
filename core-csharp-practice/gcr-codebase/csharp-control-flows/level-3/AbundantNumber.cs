using System;

class AbundantNumber
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //input 

        int sum = 0;

       
        for (int i = 1; i < number; i++) //loop 
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        // Check abundant condition
        if (sum > number)
            Console.WriteLine("It is an Abundant Number");
        else
            Console.WriteLine("It is NOT an Abundant Number");
    }
}
