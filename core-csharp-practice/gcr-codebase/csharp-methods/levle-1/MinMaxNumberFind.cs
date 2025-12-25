using System;

class MinMaxNumberFind
{
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3) //method 
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3)); //condition for samllest number
        int largest = Math.Max(number1, Math.Max(number2, number3)); //condition for largest  number 
        return new int[] { smallest, largest };
    }

    static void Main()
    {
        Console.Write("Enter first number: "); //take inputs 
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int[] result = FindSmallestAndLargest(a, b, c); //method  call 

        Console.WriteLine("Smallest: " + result[0]);  //output of smallest number
        Console.WriteLine("Largest: " + result[1]); //output of largewst number 
    } 
}
