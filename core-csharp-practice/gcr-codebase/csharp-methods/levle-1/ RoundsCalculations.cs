using System;

class RoundsCalculations
{
    // Method 
    static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double distance = 5000; // 5 km in meters
        return distance / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1: "); //inputs 
        double s1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double s2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double s3 = double.Parse(Console.ReadLine());

        double rounds = CalculateRounds(s1, s2, s3); //method call 

        Console.WriteLine("Number of rounds needed: " + rounds); //output 

    }
}
