using System;

class NumberCheckpalinAndDuck
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

    // Reverse digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reverse = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reverse[i] = digits[digits.Length - 1 - i];
        }
        return reverse;
    }

    // Compare two arrays
    public static bool AreArraysEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }

    // Check Palindrome Number
    public static bool IsPalindrome(int[] original, int[] reversed)
    {
        return AreArraysEqual(original, reversed);
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

    // Main Method
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = GetDigits(number, count);
        int[] reversed = ReverseArray(digits);

        Console.WriteLine("Palindrome Number: " + IsPalindrome(digits, reversed));
        Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
    }
}
