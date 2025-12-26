using System;

class ArrayIndexOutOfRangeExceptionExample

{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };

        try
        {
            // Invalid array index
            Console.WriteLine(arr[5]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException Find ");
        }
    }
}
