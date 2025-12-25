using System;
using System.Xml;

class LeapYearCheck
{
    static bool IsLeapYear(int year) //method 
    {
        if (year < 1582) return false;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); //codn
    }

    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine()); //inpyut 

        Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year"); //output and condition
    }
}
