using System;

class AnagramCheckFn
{
    static void Main()
    {
        Console.Write("Enter first string: "); //inputs 
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        char[] a1 = s1.ToCharArray();
        char[] a2 = s2.ToCharArray();

        Array.Sort(a1);
        Array.Sort(a2);

        if (new string(a1).Equals(new string(a2)))
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are not Anagrams");
    }
}
