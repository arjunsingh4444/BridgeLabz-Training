using System;

class NumberCheckprimeBuzz
{
    // Check Prime Number
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Check Neon Number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    // Check Spy Number
    public static bool IsSpyNumber(int number)
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    // Check Automorphic Number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    // Check Buzz Number
    public static bool IsBuzzNumber(int number)
    {
        return (number % 7 == 0 || number % 10 == 7);
    }

    // Main Method
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime Number: " + IsPrime(number));
        Console.WriteLine("Neon Number: " + IsNeonNumber(number));
        Console.WriteLine("Spy Number: " + IsSpyNumber(number));
        Console.WriteLine("Automorphic Number: " + IsAutomorphicNumber(number));
        Console.WriteLine("Buzz Number: " + IsBuzzNumber(number));
    }
}
