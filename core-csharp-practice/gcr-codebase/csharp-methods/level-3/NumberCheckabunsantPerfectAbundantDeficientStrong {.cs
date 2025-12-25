using System;

class NumberCheckabunsantPerfectAbundantDeficientStrong
{
    // Method to find all factors of a number
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop to store factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    // Method to find greatest factor
    public static int GreatestFactor(int[] factors)
    {
        int max = factors[0];
        foreach (int factor in factors)
        {
            if (factor > max)
                max = factor;
        }
        return max;
    }

    // Method to find sum of factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
            sum += factor;

        return sum;
    }

    // Method to find product of factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
            product *= factor;

        return product;
    }

    // Method to find product of cube of factors
    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
            product *= Math.Pow(factor, 3);

        return product;
    }

    // Check Perfect Number
    public static bool IsPerfectNumber(int number, int[] factors)
    {
        int sum = 0;

        foreach (int factor in factors)
        {
            if (factor != number)   // proper divisors
                sum += factor;
        }
        return sum == number;
    }

    // Check Abundant Number
    public static bool IsAbundantNumber(int number, int[] factors)
    {
        int sum = 0;

        foreach (int factor in factors)
        {
            if (factor != number)
                sum += factor;
        }
        return sum > number;
    }

    // Check Deficient Number
    public static bool IsDeficientNumber(int number, int[] factors)
    {
        int sum = 0;

        foreach (int factor in factors)
        {
            if (factor != number)
                sum += factor;
        }
        return sum < number;
    }

    // Method to find factorial
    public static int Factorial(int digit)
    {
        int fact = 1;
        for (int i = 1; i <= digit; i++)
            fact *= i;

        return fact;
    }

    // Check Strong Number
    public static bool IsStrongNumber(int number)
    {
        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    // Main Method
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("\nFactors:");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine("\n\nGreatest Factor: " + GreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + ProductOfCubeOfFactors(factors));

        Console.WriteLine("\nPerfect Number: " + IsPerfectNumber(number, factors));
        Console.WriteLine("Abundant Number: " + IsAbundantNumber(number, factors));
        Console.WriteLine("Deficient Number: " + IsDeficientNumber(number, factors));
        Console.WriteLine("Strong Number: " + IsStrongNumber(number));
    }
}
