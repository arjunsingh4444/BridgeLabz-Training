using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());  //input a

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());  //input b

        Console.Write("Enter third number: ");
        double c = Convert.ToDouble(Console.ReadLine());  //input c

        double average = (a + b + c) / 3; //avg

        Console.WriteLine("Average = " + average); //output
    }
}
