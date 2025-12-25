using System;

class ChocolateDistribution
{
    // Method 
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;   // chocolates each child gets
        int remainder = number % divisor;  // remaining chocolates

        return new int[] { quotient, remainder };
    }

    static void Main()
    {
        Console.Write("Enter total number of chocolates: ");  //inputs 
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Call method
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        //output
        Console.WriteLine("Each child gets: " + result[0] + " chocolates");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }
}
