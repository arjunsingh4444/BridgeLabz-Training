using System;
using System.Collections.Generic;

class Palindrome
{
    static bool IsPalindrome(Stack<char> stack)
    {
        if (stack.Count <= 1)
            return true;

        char top = stack.Pop();

        bool result = IsPalindrome(stack);

        char bottom = RemoveBottom(stack);

        stack.Push(bottom);
        stack.Push(top);

        return result && (top == bottom);
    }

    static char RemoveBottom(Stack<char> stack)
    {
        char top = stack.Pop();

        if (stack.Count == 0)
            return top;

        char bottom = RemoveBottom(stack);

        stack.Push(top);

        return bottom;
    }

    static void Main()
    {
        Stack<char> stack = new Stack<char>();
        string word = "ara"; 

        foreach (char c in word)
            stack.Push(c);

        if (IsPalindrome(stack))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
