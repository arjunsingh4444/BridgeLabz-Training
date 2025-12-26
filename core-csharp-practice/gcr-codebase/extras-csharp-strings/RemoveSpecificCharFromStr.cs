using System;

class RemoveSpecificCharFromStr
{
    static void Main()
    {
        Console.Write("Enter string: "); //taken inputs from user 
        string text = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char removeChar = Console.ReadLine()[0]; //reading the first character of the input as the character to remove

        string result = "";

        foreach (char c in text) //loop through each character in the string
        {
            if (c != removeChar)
                result += c;
        }

        Console.WriteLine(" String = " + result); //output
    }
}
