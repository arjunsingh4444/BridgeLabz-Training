using System;

class RemoveDuplicates
{
    static void Main()
    {
        Console.Write("Enter a string: "); //take input 
        string text = Console.ReadLine();

        string result = "";

        foreach (char c in text)
        {
            // Add character if not there in result 
            if (!result.Contains(c))
                result += c;
        }

        Console.WriteLine("After delete  Duplicate we have output =  " + result);
    }
}
