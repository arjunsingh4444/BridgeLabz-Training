using System;

class TrigonometryFn
{
    // Methods
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180; //angle to radian

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees ="); //take angle 
        double angle = double.Parse(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle); //call method 

        Console.WriteLine("Sine: " + result[0]); //outputs
        Console.WriteLine("Cosine: " + result[1]);
        Console.WriteLine("Tangent: " + result[2]);
    }
}
