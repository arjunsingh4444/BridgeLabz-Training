using System;

public class NumberDivisibility
{
    public static void Main()
    {
        Console.WriteLine("Enter a Number:");
        int Number =int.Parse(Console.ReadLine());  // Reading input from user
        if (Number % 5 == 0) //check devisibility
        {
            Console.WriteLine(Number + " is divisible by 5");  //output 
        }
        else
        {
            Console.WriteLine("Number is not divisible by 5"); //if not 
        }
    }


}
           
