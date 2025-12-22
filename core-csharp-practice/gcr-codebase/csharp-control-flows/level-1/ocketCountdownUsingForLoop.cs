using System;

class RocketCountdownUsingForLoop
{
    static void Main(string[] args)
    {
        // Input value
        Console.WriteLine("Enter countdown number:");
        int number = int.Parse(Console.ReadLine());

        // Countdown using for loop
        for (int i = number; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
