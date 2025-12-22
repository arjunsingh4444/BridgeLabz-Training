using System;

class SmallestNumberBetweenThree
{
    static void Main(string[] args)
    {
        // Input three numbers
        Console.WriteLine("Enter three numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        // Check if first number is smallest
        bool isSmallest = (number1 < number2 && number1 < number3);

        // Output result
        Console.WriteLine("Smallest no " + isSmallest);
    }
}
