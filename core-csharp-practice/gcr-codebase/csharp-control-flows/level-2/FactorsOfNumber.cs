using System;

class FactorsOfNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //take number 

        Console.WriteLine("Factors are:"); 

        for (int i = 1; i < number; i++) //lopp 
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
