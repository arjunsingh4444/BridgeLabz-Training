using System;

class UnitChanger2
{
    //  yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    //  inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    //inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    static void Main()
    {
        Console.WriteLine("5 Yards in Feet: " + ConvertYardsToFeet(5)); //outputs 
        Console.WriteLine("6 Feet in Yards: " + ConvertFeetToYards(6));
        Console.WriteLine("2 Meters in Inches: " + ConvertMetersToInches(2));
        Console.WriteLine("10 Inches in Meters: " + ConvertInchesToMeters(10));
        Console.WriteLine("10 Inches in CM: " + ConvertInchesToCentimeters(10));
    }
}
