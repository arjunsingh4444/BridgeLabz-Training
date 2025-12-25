using System;

class NumberTester
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

    // Check Duck Number (contains zero)
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d == 0)
                return true;
        }
        return false;
    }

    // Check Armstrong Number
    public static bool IsArmstrong(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;

        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, power);
        }
        return sum == number;
    }

    // Find largest and second largest digit
    public static void FindLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest)
            {
                secondLargest = d;
            }
        }

        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }

    // Find smallest and second smallest digit
    public static void FindSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int d in digits)
        {
            if (d < smallest)
            {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest)
            {
                secondSmallest = d;
            }
        }

        Console.WriteLine("Smallest Digit: " + smallest);
        Console.WriteLine("Second Smallest Digit: " + secondSmallest);
    }

    // Main Method
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = GetDigits(number, count);

        Console.WriteLine("Digit Count: " + count);

        Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrong(number, digits));

        FindLargest(digits);
        FindSmallest(digits);
    }
}
