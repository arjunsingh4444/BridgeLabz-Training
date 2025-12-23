using System;

class NumberTypefinding
{
    static void Main()
    {
        int[] numbers = new int[5];

       
        for (int i = 0; i < numbers.Length; i++) //take input 
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < numbers.Length; i++) //
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i] + "  Positive Even");
                else
                    Console.WriteLine(numbers[i] + "  Positive Odd");
            }
            else if (numbers[i] < 0)
                Console.WriteLine(numbers[i] + " is Negative");
            else
                Console.WriteLine("Zero");
        }

        // Compare first and last element
        if (numbers[0] == numbers[4])
            Console.WriteLine("First and last num are equal");
        else if (numbers[0] > numbers[4])
            Console.WriteLine("First num is greater");
        else
            Console.WriteLine("Last num is greater");
    }
}
