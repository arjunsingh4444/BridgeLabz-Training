using System;

class LargestAndSecondLargestNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()); //take a number 

        int maxDigit = 4;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Store digits
        while (number != 0 && index < maxDigit)
        {
            digits[index++] = number % 10; //srore in array eacj=g digit 

            number /= 10; //remove from last digit 
        }

        int largest = 0, secondLargest = 0; //initilize both num to zero

        // Find largest and second largest
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + secondLargest);
    }
}
