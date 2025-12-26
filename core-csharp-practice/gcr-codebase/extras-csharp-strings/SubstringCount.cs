using System;

class SubstringCount
{
    static void Main()
    {
        Console.Write("Enter main string: "); //take inputs
        string text = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++) //loop through the main string
        {
            if (text.Substring(i, sub.Length).Equals(sub)) //check if the substring matches the main string
                count++;
        }

        Console.WriteLine("occurrences  of substring =" + count); //output 
    }
}
