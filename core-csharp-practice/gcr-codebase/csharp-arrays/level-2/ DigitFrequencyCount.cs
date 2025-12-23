using System;

class DigitFrequencyCount
{
    static void Main()
    {
        Console.Write("Enter a number: "); //take input 
        int number = int.Parse(Console.ReadLine());

        int[] freq = new int[10]; //create freq array

        while (number != 0)
        {
            int digit = number % 10; //find the last digit of the number
            
            freq[digit]++; //increment the frequency of the digit
            number /= 10; //remove the last digit from the number
        }

        for (int i = 0; i < 10; i++)
            Console.WriteLine("Digit " + i + " occurs " + freq[i] + " times");
    }
}
