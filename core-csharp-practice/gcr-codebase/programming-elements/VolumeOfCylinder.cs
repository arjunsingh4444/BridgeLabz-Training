using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());  //input radius

        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());  //input height

        double volume = Math.PI * radius * radius * height;  //calculate volume

        Console.WriteLine(volume);   //output 
    }
}
