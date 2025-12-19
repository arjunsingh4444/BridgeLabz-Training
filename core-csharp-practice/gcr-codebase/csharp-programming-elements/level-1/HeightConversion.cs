using System;

class HeightConversion
{
    static void Main()
    {
        Console.Write("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());//user input of height 

        double inches = heightCm / 2.54; // height in inches 
        double feet = inches / 12;// height in feet

        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet} and inches is {inches}");//output
    }
}
