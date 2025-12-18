using System;
public class PowerCalculation
{
    public static void Main()
    {
        double baseNumber = 2;  //base no
        int exponent = 3;   //exponent 
        double result = Math.Pow(baseNumber, exponent);  //power calculation using Math.Pow() method
        Console.WriteLine( result); //output 
    }
}