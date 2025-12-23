using System;

class FactorsOfANumber
{
    static void Main()
    {
        Console.Write("Enter a number");
        int number = int.Parse(Console.ReadLine()); //input take 

    
        int[] factors = new int[10];
        int Index=0;
        

        for (int i = 1; i <=number; i++)
        {
            if (number % i == 0)

            {
                factors[Index] = i;
                Index++;

            }
        }

        Console.WriteLine("Factors are ");
        for (int i = 0; i < number; i++)
            Console.Write(factors[i]);
    }
}
