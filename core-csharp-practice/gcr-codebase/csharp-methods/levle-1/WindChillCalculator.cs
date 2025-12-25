using System;

class WindChillCalculator
{
    public static double CalculateWindChill(double temperature, double windSpeed)     //method 
    {
        return 35.74 + 0.6215 * temperature +(0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);     //method return 
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");                 //inputs 
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double speed = double.Parse(Console.ReadLine());

        double windChill = CalculateWindChill(temp, speed);

        Console.WriteLine("Wind Chill Temperature: " + windChill); //output 
    }
}
