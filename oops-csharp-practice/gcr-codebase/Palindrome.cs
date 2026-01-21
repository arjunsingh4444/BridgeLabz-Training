using System;
using System.Collections.Generic;

class Palindrome
{
    static void Main()
    {
        string word = "ajra";   
        Stack<char> stack = new Stack<char>();


        foreach (char c in word)
        {
            stack.Push(c);
        }

        bool isPalindrome = true;

        // Compare characters
        foreach (char c in word)
        {
            if (stack.Pop() != c)
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
