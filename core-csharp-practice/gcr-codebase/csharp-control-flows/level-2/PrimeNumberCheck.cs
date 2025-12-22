using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        // Input num
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Prime numbers are greater than 1
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;

        // Check divisibility
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Output result
        if (isPrime)
            Console.WriteLine("The number is Prime");
        else
            Console.WriteLine("The number is NOT Prime");
    }
}
