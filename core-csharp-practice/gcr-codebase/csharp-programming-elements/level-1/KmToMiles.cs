using System;
public class KmToMiles
{
    public static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());  // Read distance in kilometers
        double miles = km / 1.6;  // Convert kilometers to miles
        Console.WriteLine(miles);  //output the result
    }
}