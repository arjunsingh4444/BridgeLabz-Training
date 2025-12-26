using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a string: "); //take input 
        string text = Console.ReadLine();

        if (IsPalindrome(text))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }

    // Function to check palindrome
    static bool IsPalindrome(string s) //method 
    {
        int start = 0;
        int end = s.Length - 1;

        while (start < end) //loop until start and end are equal
        {
            if (s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
}
