using System;

class CountVowelsConsonantsNo
{
    static void Main()
    {
        Console.Write("Enter a string: "); //take input 
        string text = Console.ReadLine().ToLower();

        int vowels = 0, consonants = 0; //initialize variables

        foreach (char c in text)
        {
            // Check only alphabets
            if (c >= 'a' && c <= 'z')
            {
                // Check vowels
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') //conditions 
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels are  " + vowels); //outputs

        Console.WriteLine("Consonants are  " + consonants);
    }
}
