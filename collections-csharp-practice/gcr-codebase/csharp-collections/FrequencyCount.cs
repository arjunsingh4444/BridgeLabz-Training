using System;
using System.Collections.Generic;

class FrequencyCount
{
    static void Main()
    {
        string[] fruits = { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string fruit in fruits)
        {
            if (freq.ContainsKey(fruit))
                freq[fruit]++;
            else
                freq[fruit] = 1;
        }

        foreach (var item in freq)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}
