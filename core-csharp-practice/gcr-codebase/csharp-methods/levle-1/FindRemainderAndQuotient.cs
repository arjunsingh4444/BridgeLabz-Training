using System;
using System.Runtime.CompilerServices;

class FindRemainderAndQuotient
{
    public static int[] FindRemainderAndQuotient(int number, int divisor) //method for givien question 
    {
        int quotient = number / divisor; //conditions 
        int remainder = number % divisor;
        return new int[] { quotient, remainder };//learn it 
    }

    static void Main()
    {
        Console.Write("Enter number: "); //take inputs 
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor); //call method

        Console.WriteLine("Quotient: " + result[0]); //outputs 
        Console.WriteLine("Remainder: " + result[1]);
    }
}
