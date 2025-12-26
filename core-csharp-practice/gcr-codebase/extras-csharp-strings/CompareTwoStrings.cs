using System;

class CompareTwoStrings
{
    static void Main()
    {
        Console.Write("first stringis = ");
        string s1 = Console.ReadLine();

        Console.Write("second string is = ");
        string s2 = Console.ReadLine();

        //  comparison
        bool result = CompareUsingCharAt(s1, s2);

        Console.WriteLine("CharAt Comparison output  " + result);
        Console.WriteLine("Built-in  function " + s1.Equals(s2));
    }

    // Method 
    static bool CompareUsingCharAt(string a, string b)
    {
        if (a.Length != b.Length) //conditions 
            return false;

        for (int i = 0; i < a.Length; i++) //loop to compare each character 
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }
}
