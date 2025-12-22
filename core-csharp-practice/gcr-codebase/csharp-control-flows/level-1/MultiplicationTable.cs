using System;

class MultiplicationTableEasy
{
    static void Main(string[] args)
    {
        // Ask the user to enrer a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Print multiplication table from 6 to 9
        Console.WriteLine("Multiplication Table:");

        for (int i = 6; i <= 9; i++)
        {
            // wirte  multiplication result
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
