using System;

class DateComparison
{
    static void Main()
    {
        Console.Write("Enter first date (yyyy-mm-dd): "); //take inputs of two dates 
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-mm-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        // Compare dates
        if (date1 < date2)
            Console.WriteLine("First date is before second date");
        else if (date1 > date2)
            Console.WriteLine("First date is after second date");
        else
            Console.WriteLine("Both dates are euual ");
    }
}
