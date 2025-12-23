using System;

class OddEvenCheckAndStore
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());//take input 

        int[] even = new int[number / 2 + 1]; //arrayy for even 
        int[] odd = new int[number / 2 + 1]; //for odd num 
 
        int eIndex = 0, oIndex = 0;

        for (int i = 1; i <= number; i++) //loop for input number 
        {
            if (i % 2 == 0) //condn
                even[eIndex++] = i;
            else
                odd[oIndex++] = i;
        }

        Console.WriteLine("Even Numbers:"); //output for even 
        for (int i = 0; i < eIndex; i++)
            Console.Write(even[i]);

        Console.WriteLine("Odd Numbers:"); //output for odd 
        for (int i = 0; i < oIndex; i++)
            Console.Write(odd[i]);
    }
}
