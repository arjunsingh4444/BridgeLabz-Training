/*
This program performs analysis on a sentence entered by the user.

1. It counts the total number of words in the sentence.
2. It finds and displays the longest word in the sentence and its length.
3. It allows the user to replace an old word with a new word in the sentence.

The program uses:
- String.Split() to separate words
- Looping and condition checks to find the longest word
- String.Replace() to replace words
- Separate methods for each operation to follow modular programming
*/




using System;
using System.Text;
class ParaCount
{
    //method to replace a word in a sentence 
    string replaceWord(string str)
    {
        Console.WriteLine("enter old word for replace");  //enter old word 
        string s1 =  Console.ReadLine();
        Console.WriteLine("enter new word for replace"); //enter new word 
        string s2 =   Console.ReadLine();
       
       String text = str.Replace(s1,s2); //replace old word with new word
       return text;


    }
    //method to find longest word in a sentence 
    string longestWord(string str) 
    {
        string[] arr = str.Split(' '); //split the sentence into words 
        String longest = arr[0];
        for(int i = 1; i < arr.Length; i++) //loop through the words
        {
            if (arr[i].Length > longest.Length)
            {
                longest = arr[i];
            }
        }
        return longest;
        
        
    }
    //method to count the number of words in a sentence 
    int count(string str) 
    {
        string[] arr = str.Split(' '); //spllit and trim sentence 
        int count = 0;
        foreach(string word in arr)
        {
            if(word!= "")
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Entere  a Sentence to Analyse");
        string str = Console.ReadLine();
        ParaCount obj = new ParaCount();

        if(obj.count(str)!=0){
        Console.WriteLine("total number of words in Sentence  "+obj.count(str));
         Console.WriteLine("longest word is: "+obj.longestWord(str));
        Console.WriteLine("the length of longest word is: "+obj.longestWord(str).Length);
        Console.WriteLine("the replacing of word: "+obj.replaceWord(str));
        }
        else
        {
            Console.WriteLine("no string found");
        }
    }
}