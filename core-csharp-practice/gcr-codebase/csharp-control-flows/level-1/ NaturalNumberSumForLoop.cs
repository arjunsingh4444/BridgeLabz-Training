
using System;

class NaturalNumberSumForLoop
{
    static void Main(string[] args)
    {
        //  user to enter a number
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        // Check if the number is a natural number
        if (n > 0)
        {
            
            int sumUsingForLoop = 0;

            // Calculate sum using for loop
            for (int i = 1; i <= n; i++)
            {
                sumUsingForLoop += i;
            }

            // Calculate sum using formula
            int sumUsingFormula = n * (n + 1) / 2;

            // Display both results
            Console.WriteLine($"Sum using for loop is {sumUsingForLoop}");
            Console.WriteLine($"Sum using formula is {sumUsingFormula}");

            // Compare both results
            if (sumUsingForLoop == sumUsingFormula)
            {
                Console.WriteLine("Both results are correct and equal.");
            }
            else
            {
                Console.WriteLine("Results are not equal.");
            }
        }
        else
        {
            // If number is not natural
            Console.WriteLine("invalid number ");
        }
    }
}
