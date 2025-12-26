using System;

class ToggleCaseFunction
{
    static void Main()
    {
        Console.Write("Enter a string: "); //input 
        string text = Console.ReadLine();

        string result = "";

        foreach (char c in text)
        {
            // Uppercase to lowercase
            if (char.IsUpper(c))
                result += char.ToLower(c);
            // Lowercase to uppercase
            else if (char.IsLower(c))
                result += char.ToUpper(c);
            else
                result += c;
        }

        Console.WriteLine("Toggled String is = " + result);
    }
}
