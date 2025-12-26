// using System;

// class WordSplitfn
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: "); //take input by user 
//         string text = Console.ReadLine();

//         string word = "";
//         int length = 0;

//         for (int i = 0; i < text.Length; i++)
//         {
//             // If character is not space, add to word
//             if (text[i] != ' ')
//             {
//                 word += text[i];
//                 length++;
//             }
//             else
//             {
//                 // Space found → print word and length
//                 Console.WriteLine(word + " has  length of " + length);

//                 // null for next word
//                 word = "";
//                 length = 0;
//             }
//         }

//         // Print last word bcz in last we not found any space
//         Console.WriteLine(word + "has length of  " + length);
//     }
// }



//////////using biuilt in function 



using System;

class WordSplitBuiltIn
{
    static void Main()
    {
        // Take input
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        // Split sentence into words using space
        string[] words = text.Split(' ');

        // Display each word and its length
        foreach (string word in words)
        {
            Console.WriteLine(word + "has length of " + word.Length);
        }
    }
}

