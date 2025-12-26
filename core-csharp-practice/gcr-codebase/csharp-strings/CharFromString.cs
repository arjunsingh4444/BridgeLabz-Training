using System;

class CharFromString
{
    static void Main()
    {
        Console.Write("Enter string: "); //take input 
        string text = Console.ReadLine();

        char[] chars = GetCharacters(text); //convert to chat array

        Console.WriteLine("Characters:"); //print characters 
        foreach (char c in chars)
            Console.Write(c + " ");

        Console.WriteLine("\nUsing ToCharArray:"); //using built in function 
        foreach (char c in text.ToCharArray())
            Console.Write(c + " ");
    }

    // Convert string to char array without ToCharArray
    static char[] GetCharacters(string s)
    {
        char[] arr = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
            arr[i] = s[i];

        return arr;
    }
}
