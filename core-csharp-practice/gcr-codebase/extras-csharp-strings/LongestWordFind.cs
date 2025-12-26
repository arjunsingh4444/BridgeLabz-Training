using System;

class LongestWordFind
{
    static void Main()
    {
        Console.Write("Enter a sentence: "); //input a sentence
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        string longest = words[0];

        foreach (string word in words) //loop through each word in the sentence
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine("Longest Word is = " + longest); //output the longest word
    }
}
