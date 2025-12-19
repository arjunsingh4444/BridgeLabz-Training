using System;

class TriangleArea
{
    static void Main()
    {
        Console.Write("Enter base: ");
        double baseValue = Convert.ToDouble(Console.ReadLine()); //base value 

        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());  //height 

        double area = 0.5 * baseValue * height;   //area. formula

        Console.WriteLine($"The area of triangle is {area}");  //output 
    }
}
