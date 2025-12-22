using System;

class LeapYearCheck
{
    static void Main(string[] args)
    {
        // Take year I/P
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());


        if (year >= 1582) //cond
        {
            // leap year rules
            if (year % 400 == 0)
                Console.WriteLine("Year is a Leap Year");
            else if (year % 100 == 0)
                Console.WriteLine("Year is NOT a Leap Year");
            else if (year % 4 == 0)
                Console.WriteLine("Year is a Leap Year");
            else
                Console.WriteLine("Year is NOT a Leap Year");
        }
        else // if not aftrerb  1582 
        {
            Console.WriteLine("Year should be 1582 or later");
        }
    }
}
