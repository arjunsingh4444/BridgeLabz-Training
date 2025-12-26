using System;

class UpperCaseConversion
{
    static void Main()
    {
        Console.Write("Enter text= "); //take sting
        string text = Console.ReadLine();

        Console.WriteLine("Custom Uppercase: " + ToUpper(text)); //outputs 
        Console.WriteLine("Built-in fn: " + text.ToUpper());
    }

    static string ToUpper(string s) //method for upper case conmversion 
    {
        string result = "";

        for (int i = 0; i < s.Length; i++) //loop for conversion 
        {
            char c = s[i];

            // ASCII conversion
            if (c >= 'a' && c <= 'z')
                result += (char)(c - 32);
            else
                result += c;
        }
        return result; //return
    }
}
