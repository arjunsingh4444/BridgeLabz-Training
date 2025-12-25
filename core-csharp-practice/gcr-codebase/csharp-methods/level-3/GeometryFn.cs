using System;

class GeometryFn
{
    // calculate Euclidean distance between two points
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    //  find slope (m) and y-intercept (b) of the line
    public static double[] LineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);  // slope
        double b = y1 - m * x1;            // y-intercept

        return new double[] { m, b };      // return slope and intercept
    }

    // Main Method
    static void Main()
    {
        // Input two points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate Euclidean distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("\nEuclidean Distance: " + distance);

        // Find line equation
        double[] line = LineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of Line: y = " + line[0] + "x + " + line[1]);
    }
}
