using System;
using System.Collections.Generic;

class Palindrome
{
    static bool IsPalindrome(Stack<char> stack, Stack<char> temp)
    {
        if (stack.Count == 0) //base case
            return true;

        char top = stack.Pop();

        bool result = IsPalindrome(stack, temp); //recursive call

        char tempTop = temp.Pop(); 

        stack.Push(top); //fill stack

        return result && (top == tempTop);
    }

    static void Main()
    {
        string word = "arjun";

        Stack<char> stack = new Stack<char>();
        Stack<char> temp = new Stack<char>();

        foreach (char c in word) 
        {
            stack.Push(c);  
            temp.Push(c);  
        }

        if (IsPalindrome(stack, temp))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
