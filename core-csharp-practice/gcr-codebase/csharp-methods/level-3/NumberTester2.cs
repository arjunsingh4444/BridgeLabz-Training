using System;

class NumberTester2
{
    // Count digits in a number
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Store digits in array
    public static int[] GetDigits(int number, int count)
    {
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Find sum of digits
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
        {
            sum += d;
        }
        return sum;
    }

    // Find sum of squares of digits
    public static int SumOfSquares(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, 2);
        }
        return sum;
    }

    // Check Harshad Number
    public static bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }

    // Find frequency of each digit 
    public static int[,] DigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];

        // Initialize digits column
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
        }

        // Count frequency
        foreach (int d in digits)
        {
            frequency[d, 1]++;
        }

        return frequency;
    }

    // Main Method
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = GetDigits(number, count);

        int sum = SumOfDigits(digits);
        int squareSum = SumOfSquares(digits);

        Console.WriteLine("Sum of Digits: " + sum);
        Console.WriteLine("Sum of Squares of Digits: " + squareSum);

        Console.WriteLine("Harshad Number: " + IsHarshadNumber(number, sum));

        Console.WriteLine("\nDigit Frequency:");
        Console.WriteLine("Digit\tCount");

        int[,] freq = DigitFrequency(digits);
        for (int i = 0; i < 10; i++)
        {
            if (freq[i, 1] > 0)
            {
                Console.WriteLine(freq[i, 0] + "\t" + freq[i, 1]);
            }
        }
    }
}
