using System;

class SubstringFinder
{
    static void Main()
    {
        Console.Write("Enter string == "); //take input from user for string 
        string text = Console.ReadLine();

        Console.Write("Enter start index = "); //start index of string 
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index  = "); //bnd index of string 
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Custom Substring: " + CreateSubstring(text, start, end));//outputs
        Console.WriteLine("Built-in Substring: " + text.Substring(start, end - start));
    }

//method    
    static string CreateSubstring(string s, int start, int end)
    {
        string result = "";

        for (int i = start; i < end; i++)
        {
            result += s[i];
        }
        return result;
    }
}
