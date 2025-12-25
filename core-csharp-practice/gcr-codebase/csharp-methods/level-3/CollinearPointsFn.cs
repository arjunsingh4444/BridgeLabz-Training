using System;

class CollinearPointsFn
{
    // Method to check collinearity using slope method
    public static bool IsCollinearBySlope(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeAC;
    }

    // Method to check collinearity using area of triangle method
    public static bool IsCollinearByArea(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double area = 0.5 * (
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2)
        );

        return area == 0;
    }

    // Main Method
    static void Main()
    {
        // Sample input points
        double x1 = 2, y1 = 4;
        double x2 = 4, y2 = 6;
        double x3 = 6, y3 = 8;

        // Check using slope method
        bool slopeResult = IsCollinearBySlope(x1, y1, x2, y2, x3, y3);

        // Check using area method
        bool areaResult = IsCollinearByArea(x1, y1, x2, y2, x3, y3);

        // Display results
        Console.WriteLine("Using Slope Method: " + slopeResult);
        Console.WriteLine("Using Area Method: " + areaResult);

        if (slopeResult && areaResult)
            Console.WriteLine("Points are Collinear");
        else
            Console.WriteLine("Points are NOT Collinear");
    }
}
