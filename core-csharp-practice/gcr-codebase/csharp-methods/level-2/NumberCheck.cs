using System;

class NumberCheck
{
    //  check positive or negative
    static bool IsPositive(int number)
    {
        return number >= 0;
    }

    // check even or odd
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    //compare two numbers
    static int CompareNumbers(int first, int last)
    {
        if (first > last) return 1;
        if (first < last) return -1;
        return 0;
    }

    static void Main()
    {
        int[] numbers = new int[5];

        // Take 5 numbers from user
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            numbers[i] = int.Parse(Console.ReadLine());

            // Check positive or negative
            if (IsPositive(numbers[i]))
            {
                // If positive, check even or odd
                if (IsEven(numbers[i]))
                    Console.WriteLine("Positive and Even");
                else
                    Console.WriteLine("Positive and Odd");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
        }

        // Compare first and last element
        int result = CompareNumbers(numbers[0], numbers[4]);

        if (result == 0)
            Console.WriteLine("First and Last numbers are Equal");
        else if (result == 1)
            Console.WriteLine("First number is Greater than Last number");
        else
            Console.WriteLine("First number is Smaller than Last number");
    }
}
