using System;

class LargestNumberBetweenThree
{
    static void Main(string[] args)
    {
        // Input values
        Console.WriteLine("Enter three numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        bool isFirstLargest = number1 > number2 && number1 > number3;
        bool isSecondLargest = number2 > number1 && number2 > number3;
        bool isThirdLargest = number3 > number1 && number3 > number2;

        // Output result
        Console.WriteLine("The largest number between the three numbers is:");
        if (isFirstLargest)
        {
            Console.WriteLine(number1);
        }
        else if (isSecondLargest)
        {
            Console.WriteLine(number2);
        }
        else if (isThirdLargest)
        {
            Console.WriteLine(number3);
        }
        else
        {
            Console.WriteLine("None of the numbers are the largest.");
        }
    }
}
