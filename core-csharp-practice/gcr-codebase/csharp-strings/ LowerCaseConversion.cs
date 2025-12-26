using System;

class LowerCaseConversion
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Custom Lowercase: " + ToLower(text));
        Console.WriteLine("Built-in Lowercase: " + text.ToLower());
    }

    static string ToLower(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c >= 'A' && c <= 'Z')
                result += (char)(c + 32);
            else
                result += c;
        }
        return result;
    }
}
