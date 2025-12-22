using System;

class OddEvenNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //input 

        for (int i = 1; i <= number; i++) //loop
        {
            if (i % 2 == 0)
                Console.WriteLine("Even" + i);
            else
                Console.WriteLine("Odd" + i);
        }
    }
}
