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

            for(int i=2;i<=number;i++)  //condition
            {
                factorial *= i;
            }


            Console.WriteLine("Factorial is " + factorial);
        }
    }
}
