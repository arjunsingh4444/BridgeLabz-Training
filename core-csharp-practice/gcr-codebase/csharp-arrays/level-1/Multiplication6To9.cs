using System;

class Multiplication6To9
{
    static void Main()
    {
        Console.Write("Enter a number: "); //take input 
        int number = int.Parse(Console.ReadLine());

        int[] result = new int[4]; //array for store val

        for (int i = 6; i <= 9; i++) //loop for cal/multi
        {
            result[i - 6] = number * i;
            Console.WriteLine(number + " * " + i + " = " + result[i - 6]); //ouTput 
        }
    }
}
