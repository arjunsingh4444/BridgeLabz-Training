using System;

class FormatExceptionExample
{
    static void Main()
    {
        try
        {
            // Parsing non-numeric string
            int num = int.Parse("ABC");
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException  find "); //output 
        }
    }
}
