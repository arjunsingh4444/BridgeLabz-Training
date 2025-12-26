using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter number of terms = "); //take input from user 
        int n = int.Parse(Console.ReadLine());

        PrintFibonacci(n); //call function 
    }

    // Function to print Fibonacci series
    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1, c;

        Console.Write(a + " " + b + " "); //output

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            Console.Write(c + " "); //output
            a = b;
            b = c;
        }
    }
}
