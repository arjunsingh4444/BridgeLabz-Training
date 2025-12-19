using System;

class FahrenheitToCelsiusConversion
{
    static void Main()
    {
        double fahrenheit;
        Console.WriteLine("Enter temperature in Fahrenheit:");
        fahrenheit=Convert.ToDouble(Console.ReadLine());

        double celsius=(fahrenheit-32)*5/9;      //conversion

        Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsius+" Celsius"); //output
    }
}