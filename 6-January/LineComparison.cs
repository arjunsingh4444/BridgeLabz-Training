using System;

namespace LineComparison
{
    // Abstraction
    abstract class LineBase
    {
        public abstract double CalculateLength();
    }

    // Line class
    class Line : LineBase
    {
        // Encapsulation (private variables)
        private int x1, y1, x2, y2;

        // Constructor
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Method to calculate length
        public override double CalculateLength()
        {
            double length;
            length = Math.Sqrt((x2 - x1) * (x2 - x1) +
                               (y2 - y1) * (y2 - y1));
            return length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Line 1 input
            Console.WriteLine("Enter Line 1 coordinates:");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Line line1 = new Line(x1, y1, x2, y2);

            // Line 2 input
            Console.WriteLine("Enter Line 2 coordinates:");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());

            Line line2 = new Line(x3, y3, x4, y4);

            // Calculate lengths
            double length1 = line1.CalculateLength();
            double length2 = line2.CalculateLength();

            // Display lengths
            Console.WriteLine("Line 1 Length = " + length1);
            Console.WriteLine("Line 2 Length = " + length2);

            // Compare
            if (length1 == length2)
                Console.WriteLine("Both lines are equal");
            else if (length1 > length2)
                Console.WriteLine("Line 1 is longer");
            else
                Console.WriteLine("Line 2 is longer");
        }
    }
}
