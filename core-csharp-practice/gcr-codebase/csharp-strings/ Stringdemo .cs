using System;  
class Stringdemo 
{  
    // Method to find all indexes of a character in a string  
    public static int[] FindAllIndexes(string text, char ch)  
    {  
        int count = 0;  
        for (int i = 0; i < text.Length; i++)  
        {  
            if (text[i] == ch) count++;  
        }  

        int[] indexes = new int[count];  
        int j = 0;  
        for (int i = 0; i < text.Length; i++)  
        {  
            if (text[i] == ch) indexes[j++] = i;  
        }  
        return indexes;  
    }  

    static void Main(string[] args)  
    {  
        Console.Write("Enter a text: ");  
        string text = Console.ReadLine();  
        Console.Write("Enter a character to find its occurrences: ");  
        char ch = Console.ReadKey().KeyChar;  
        Console.WriteLine();  

        int[] indexes = FindAllIndexes(text, ch);  

        Console.WriteLine($"Indexes of character '{ch}': {string.Join(", ", indexes)}");  
    }  
}
