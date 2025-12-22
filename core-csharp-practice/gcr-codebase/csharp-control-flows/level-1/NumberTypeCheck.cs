using System;

class NumberTypeCheck
{
    static void Main(string[] args)
    {
        // Input number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Check condition
        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
