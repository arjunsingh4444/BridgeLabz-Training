using System;

class StringConcat //(Slow – O(N²))
{
    static void Main()
    {
        string result = "";

        for (int i = 0; i < 1000; i++)
        {
            result += i; // creates new string every time
        }

        Console.WriteLine("Done using string");
    }
}


// using System;
// using System.Text;

// class StringBuilderConcat //(Fast – O(N))
// {
//     static void Main()
//     {
//         StringBuilder sb = new StringBuilder();

//         for (int i = 0; i < 1000; i++)
//         {
//             sb.Append(i);
//         }

//         Console.WriteLine("Done using StringBuilder");
//     }
// }
