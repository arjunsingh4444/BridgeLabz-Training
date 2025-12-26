using System;

class FactorialbyRecursion
{
    static void Main()
    {
        Console.Write("Enter a number: "); //take input 
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Factorial is = " + Factorial(num));
    }

    // Recursive function for factorial
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
}
