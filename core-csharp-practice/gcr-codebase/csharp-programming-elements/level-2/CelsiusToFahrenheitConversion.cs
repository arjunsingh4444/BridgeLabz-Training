using System;

class CelsiusToFahrenheitConversion
{
    static void Main()
    {
        double celsius;
        Console.WriteLine("Enter temperature in Celsius:");
        celsius=Convert.ToDouble(Console.ReadLine());

        double fahrenheit=(celsius*9/5)+32;       //conversion

        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit"); //output
    }
}