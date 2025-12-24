using System;

class Program
{
    static void Main()
    {
        int n, sum = 0;

        Console.Write("Enter number: ");
        n = int.Parse(Console.ReadLine());

        for (int temp = n; temp > 0; temp /= 10)
        {
            sum += temp % 10;
        }

        // Check condition
        if (n % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not Harshad Number");
    }
}
