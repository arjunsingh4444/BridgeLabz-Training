using System;

class MultiplesBelowHundred
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //take input 

        Console.WriteLine("Multiples below 100:");

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
                Console.WriteLine(i);  //output 
        }
    }
}
