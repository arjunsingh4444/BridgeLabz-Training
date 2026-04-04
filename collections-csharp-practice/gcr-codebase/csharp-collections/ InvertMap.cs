using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 }, { "B", 2 }, { "C", 1 }
        };

        Dictionary<int, List<string>> output = new Dictionary<int, List<string>>();

        foreach (var item in input)
        {
            if (!output.ContainsKey(item.Value))
                output[item.Value] = new List<string>();

            output[item.Value].Add(item.Key);
        }

        foreach (var item in output)
            Console.WriteLine(item.Key + " -> " + string.Join(", ", item.Value));
    }
}
