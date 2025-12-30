using System;

class Circle
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Circle c = new Circle(r);
        c.Display();
    }
}
