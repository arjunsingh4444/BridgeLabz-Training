using System;

class MaxOfThreeNumbers
{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        // Call function to find maximum
        int max = FindMaximum(a, b, c);

        // Display result
        Console.WriteLine("Maximum number is: " + max);
    }

    // Function to find maximum number
    static int FindMaximum(int a, int b, int c)
    {
        // Assume first number is maximum
        int max = a;

        // Compare with second number
        if (b > max)
            max = b;

        // Compare with third number
        if (c > max)
            max = c;

        return max; 
    }
}
