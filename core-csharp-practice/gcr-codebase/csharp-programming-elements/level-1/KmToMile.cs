using System;

class KmToMilesInput
{
    static void Main()
    {
        Console.Write("Enter distance in km: ");
        double km = Convert.ToDouble(Console.ReadLine()); //take input from user

        double miles = km / 1.6;   //miles 

        Console.WriteLine($"The total miles is {miles} mile for the given {km} km");  //output 
    }
}
