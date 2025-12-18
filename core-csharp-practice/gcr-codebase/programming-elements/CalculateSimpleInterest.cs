using System;

public class CalculateSimpleInterest
{
    public static void Main()
    {
        Console.Write("Enter the principal amount"); 
        double principal = double.Parse(Console.ReadLine());  //input amt 

        Console.Write("Enter the rate of interest ");
        double rate = double.Parse(Console.ReadLine()); //input  rate 

        Console.Write("Enter the time period ");
        int time = int.Parse(Console.ReadLine());  //input time period 

        double interest = principal * rate * time / 100;  //interest calculation
        double simpleInterest = principal + interest;  //simple interest calculation

        Console.WriteLine( simpleInterest); //output the simple interest
    }
}