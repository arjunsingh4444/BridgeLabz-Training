using System;

class FeetToYardAndMiles
{
    static void Main()
    {
        Console.Write("Enter distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());  //input feet 

        double yards = feet / 3;   //yard 
        double miles = yards / 1760; //miles 

        Console.WriteLine($"Distance in yards is {yards} and miles is {miles}");  //output of result 
    }
}
