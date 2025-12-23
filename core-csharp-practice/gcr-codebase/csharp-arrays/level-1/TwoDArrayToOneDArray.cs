using System;

class TwoDArrayToOneDArray
{
    static void Main()
    {
        Console.Write("Enter rows = ");
        int rows = int.Parse(Console.ReadLine()); //enter row 

        Console.Write("Enter columns  ");
        int cols = int.Parse(Console.ReadLine()); //enter colm

        int[,] matrix = new int[rows, cols]; //two D array declaration 
        int[] array = new int[rows * cols];
        int index = 0;

        
        for (int i = 0; i < rows; i++) //loop for row
        {
            for (int j = 0; j < cols; j++) //loop for columns 
            {
                Console.Write("Enter element s== ");
                matrix[i, j] = int.Parse(Console.ReadLine()); //take ipurt in 2d arrays
                array[index] = matrix[i, j]; //put in oneD array
                index++;
            }
        }

        Console.WriteLine("one D Array:");
        foreach (int value in array)
            Console.Write(value);
    }
}
