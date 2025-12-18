using System;
public class KmToMiles
{
    public static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());  //converting input to double
        double miles = km * 0.621371;   //km to miles 
        Console.WriteLine(miles);  //output 
    }
}   