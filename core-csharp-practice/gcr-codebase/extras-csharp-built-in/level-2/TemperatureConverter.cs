using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.Write("Enter temperature: "); //take input
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C or F): ");
        char choice = Console.ReadLine()[0]; //take input and store first character

        if (choice == 'C')
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
        else
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
    }

    // Fahrenheit to Celsius
    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    // Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
