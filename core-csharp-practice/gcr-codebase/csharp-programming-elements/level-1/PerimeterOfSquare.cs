using System;

class SquareSide
{
    static void Main()
    {
        Console.Write("Enter perimeter: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());  //perimeter of the square is given by the user

        double side = perimeter / 4;  //side by formula 

        Console.WriteLine("side is " + side);  //output 
    }
}
