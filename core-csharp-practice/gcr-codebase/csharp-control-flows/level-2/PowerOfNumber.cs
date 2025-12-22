using System;

class PowerOfNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine()); //take input 

        Console.WriteLine("Enter power:");
        int power = int.Parse(Console.ReadLine()); //take power

        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine("Result is :"+ result);
    }
}
