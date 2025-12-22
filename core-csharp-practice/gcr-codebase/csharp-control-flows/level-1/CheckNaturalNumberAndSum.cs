using System;

class CheckNaturalNumberAndSum
{
    static void Main(string[] args)
    {
        // Input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Check natural number
        if (number > 0)
        {
            // Formula calculation
            int sum = number * (number + 1) / 2;

            // Output
            Console.WriteLine("Sum is =" + sum);
        }
        else
        {
            Console.WriteLine("Invalid number entered.");
        }
    }
}
