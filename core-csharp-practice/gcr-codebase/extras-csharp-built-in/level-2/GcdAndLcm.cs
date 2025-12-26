using System;

class GcdAndLcm
{
    static void Main()
    {
        Console.Write("Enter first number: "); //take input from user
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = FindGCD(a, b);
        int lcm = FindLCM(a, b, gcd);

        Console.WriteLine("GCD is = " + gcd);
        Console.WriteLine("LCM is = " + lcm);
    }

    // Function to find GCD
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to find LCM
    static int FindLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}
