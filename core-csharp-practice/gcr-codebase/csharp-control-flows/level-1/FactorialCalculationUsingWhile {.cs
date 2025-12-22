using System;

class FactorialCalculationUsingWhile
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());  //input 
   
        if (number > 0)   //condition
        {
            int factorial = 1;
            int i = 1;

            while (i <= number)  //condition
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine("Factorial is " + factorial);
        }
    }
}
