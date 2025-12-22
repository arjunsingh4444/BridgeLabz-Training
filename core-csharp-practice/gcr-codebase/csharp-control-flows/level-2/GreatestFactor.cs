using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");  //take input by user 
        int number = int.Parse(Console.ReadLine());

        int greatestFactor = 1;

        
        for (int i = number - 1; i >= 1; i--) //loop 
        {
            if (number % i == 0) //condition 
            {
                greatestFactor = i;  //updte greatestFactor if ytrue 
                break;
            }
        }

        Console.WriteLine("Greatest factor is " + greatestFactor );  //output 
    }
}
