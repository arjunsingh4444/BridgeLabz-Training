using System;

class DateArithmetic
{
    static void Main()
    {
        Console.Write("Enter a date yyyy-mm-dd = ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        // Add 7 days
        date = date.AddDays(7);

        // Add 1 month
        date = date.AddMonths(1);

        // Add 2 years
        date = date.AddYears(2);

        // Subtract 3 weeks or  21 days
        date = date.AddDays(-21);

        Console.WriteLine("Final Date is " + date.ToShortDateString()); //output
    }
}
