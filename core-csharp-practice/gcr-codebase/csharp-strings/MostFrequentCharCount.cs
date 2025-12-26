using System;

class MostFrequentCharCount
{
    static void Main()
    {
        Console.Write("Enter string: "); //take input 
        string text = Console.ReadLine();

        int maxCount = 0;
        char mostFrequent = text[0];

        foreach (char c in text)
        {
            int count = 0;

            foreach (char x in text)
            {
                if (c == x)
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = c;
            }
        }

        Console.WriteLine($"Most Frequent used Character is ={mostFrequent} comes {maxCount} times");
    }
}
