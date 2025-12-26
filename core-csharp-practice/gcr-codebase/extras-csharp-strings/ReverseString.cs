using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: "); //take string 
        string text = Console.ReadLine();

        string reversed = "";

        // Loop from end to start
        for (int i = text.Length - 1; i >= 0; i--)
            reversed += text[i];

        Console.WriteLine("Reversed String: " + reversed); //output
    }
}
