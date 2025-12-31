using System;

class Circle
{
    private double radius;

    // Default constructor
    public Circle() : this(1.0)   // Constructor chaining
    {
    }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class circleDemo
{
    static void Main()
    {
        Circle c1 = new Circle();
        Circle c2 = new Circle(5);

        Console.WriteLine("Area of default circle: " + c1.GetArea());
        Console.WriteLine("Area of custom circle: " + c2.GetArea());
    }
}
