using System;
class FibonacciIterativeDemo
{
    static void Main() //o(n)
    {
        int n = 10;
        int a = 0, b = 1;

        for (int i = 2; i <= n; i++)
        {
            int sum = a + b;
            a = b;
            b = sum;
        }

        Console.WriteLine(b);
    }
}


// class FibonacciRecursive
// {
//     static void Main()
//     {
//         Console.WriteLine(Fibonacci(10));
//     }

//     static int Fibonacci(int n)
//     {
//         if (n <= 1)
//             return n;

//         return Fibonacci(n - 1) + Fibonacci(n - 2);
//     }
// }

