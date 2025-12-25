using System;

class NaturalNumberSumProgram
{
    static int RecursiveSum(int n) //method 
    {
        if (n == 0) return 0;
        return n + RecursiveSum(n - 1); //with recursion
    }

    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2; //with formula 
    }

    static void Main()
    {
        Console.Write("Enter a natural number: ");  //take input 
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int sum1 = RecursiveSum(n); //calling the methods
        int sum2 = FormulaSum(n);

        Console.WriteLine("Recursive Sum: " + sum1); //outputs
        Console.WriteLine("Formula Sum: " + sum2);
    }
}
