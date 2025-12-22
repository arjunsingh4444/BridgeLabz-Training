using System;

class RocketCountdownUsingWhileLoop
{
    static void Main(string[] args)
    {
        // Input countdown value
        Console.WriteLine("Enter countdown number:");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using while loop
        while (counter != 0)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
