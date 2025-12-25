using System;

class SimpleInterest
{
    // Method to calculate simple interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100; //return SI
    }

    static void Main()
    {
     
        Console.Write("Enter Principal: "); //take inputs 
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());

  
        double interest = CalculateSimpleInterest(principal, rate, time); //call method

        // Output
        Console.WriteLine( "Simple Interest is"+ interest); 
    }
}
