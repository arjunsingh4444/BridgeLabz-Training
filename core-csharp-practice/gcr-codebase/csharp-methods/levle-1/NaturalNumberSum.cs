using System;

class NaturalNumberSum
{
    // Method 
    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter n: "); //take input from user 
        int n = int.Parse(Console.ReadLine());

        int result = CalculateSum(n); //method call 
        Console.WriteLine("Sum of natural numbers: " + result);  //output 
    }
}
