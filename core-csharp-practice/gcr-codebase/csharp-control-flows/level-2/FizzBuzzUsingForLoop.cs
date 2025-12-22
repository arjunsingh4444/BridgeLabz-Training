using System;

class FizzBuzzUsingForLoop
{
    static void Main(string[] args)
    {
        // Inpu num 
        Console.WriteLine("Enter a positive number:");
        int number = int.Parse(Console.ReadLine()); 
  
        
        for (int i = 1; i <= number; i++)   // Loop from 1 to number
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");  //outputs24
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");   
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
