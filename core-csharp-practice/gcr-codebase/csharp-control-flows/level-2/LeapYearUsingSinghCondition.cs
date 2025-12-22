using System;

class LeapYearUsingSinghCondition
{
    static void Main(string[] args)
    {
        // Input year
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        //  condition
        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            Console.WriteLine("Year is a Leap Year");
        else
            Console.WriteLine("Year is NOT a Leap Year");
    }
}
