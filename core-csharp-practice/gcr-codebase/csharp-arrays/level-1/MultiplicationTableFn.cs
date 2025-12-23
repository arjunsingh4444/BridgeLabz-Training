using System;

class MultiplicationTableFn
{
    static void Main()
    {
        Console.Write("Enter a number: ");  //input for table 
        int number = int.Parse(Console.ReadLine());

        int[] table = new int[10]; //arrays 

        // Store multiplication results
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        // Display table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + table[i - 1]);
        }
    }
}
