using System;

class NullReferenceExceptionExample
{
    static void Main()
    {
        string text = null;

        try
        {
            // Calling method on null string
            Console.WriteLine(text.ToUpper());
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("NullReferenceException find ");
        }
    }
}
