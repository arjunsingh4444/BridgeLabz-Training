using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a string: "); //take input from user
        string text = Console.ReadLine();

        string reverse = "";

        for (int i = text.Length - 1; i >= 0; i--)
            reverse += text[i];
 
        if (text.Equals(reverse)) //check both asre equal or not 
            Console.WriteLine("is a Palindrome String");
        else
            Console.WriteLine("Not a Palindrome str ");
    }
}
