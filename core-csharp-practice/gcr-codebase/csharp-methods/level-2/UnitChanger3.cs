using System;

class UnitChanger3
{
    //  Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    //  Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    //  pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kg = 0.453592;
        return pounds * pounds2kg;
    }

    //  kilograms to pounds
    public static double ConvertKilogramsToPounds(double kg)
    {
        double kg2pounds = 2.20462;
        return kg * kg2pounds;
    }

    //  gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    //  liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main()
    {
        Console.WriteLine("98F in Celsius: " + ConvertFahrenheitToCelsius(98));  //outputs 
        Console.WriteLine("37C in Fahrenheit: " + ConvertCelsiusToFahrenheit(37));
        Console.WriteLine("10 Pounds in KG: " + ConvertPoundsToKilograms(10));
        Console.WriteLine("5 KG in Pounds: " + ConvertKilogramsToPounds(5));
        Console.WriteLine("2 Gallons in Liters: " + ConvertGallonsToLiters(2));
        Console.WriteLine("5 Liters in Gallons: " + ConvertLitersToGallons(5));
    }
}
