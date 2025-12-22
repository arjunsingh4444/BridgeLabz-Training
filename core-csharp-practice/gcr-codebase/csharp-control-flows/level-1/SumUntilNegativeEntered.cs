using System;

class SumUntilNegativeEntered
{
    static void Main(string[] args)
    {
        double total = 0;

        while (true)
        {
            Console.WriteLine("Enter a number:");
            double number = double.Parse(Console.ReadLine());  //input 

            if (number <= 0) //
                break;

            total += number;
        }

        Console.WriteLine("Total sum is =" + total);
    }
}
