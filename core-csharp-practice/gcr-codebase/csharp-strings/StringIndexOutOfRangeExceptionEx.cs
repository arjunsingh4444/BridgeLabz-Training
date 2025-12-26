using System;

class StringIndexOutOfRangeExceptionEx
{
    static void Main()
    {
        string text = "Hello"; //take input 

        try
        {
            // Invalid index access
            Console.WriteLine(text[10]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException Find ");
        }
    }
}
