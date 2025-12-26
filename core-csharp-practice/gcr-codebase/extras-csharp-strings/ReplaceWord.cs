using System;

class ReplaceWord
{
    static void Main()
    {
        Console.Write("Enter sentence: "); //take input 
        string sentence = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        // Replace word using built-in Replace method
        string result = sentence.Replace(oldWord, newWord);

        Console.WriteLine("Modified Sentence: " + result); //output
    }
}
