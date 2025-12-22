using System;

class SumUntilZeroEntered
{
    static void Main(string[] args)
    {
        double total = 0.0;
        double input;

        // Loop until user enters 0
        while (true)
        {
            Console.WriteLine("Enter a number (enter 0 for stop):");
            input = double.Parse(Console.ReadLine());

            if (input == 0)
                break;

            total += input;
        }

        Console.WriteLine("Total sum is" + total);
    }
}
