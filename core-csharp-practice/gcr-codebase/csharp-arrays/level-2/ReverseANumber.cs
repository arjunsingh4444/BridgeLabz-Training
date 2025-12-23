using System;

class ReverseANumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = new int[10];
        int index = 0;

        while (number != 0)
        {
            digits[index] = number % 10;
            index++;
            number /= 10;
        }

        Console.Write("Reversed Numbe is  ");
        for (int i = 0; i < index; i++)
            Console.Write(digits[i]);
    }
}
