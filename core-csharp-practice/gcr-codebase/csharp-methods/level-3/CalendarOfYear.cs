using System;

class CalendarOfYear
{
    // Method to check leap year
    public static bool IsLeapYear(int year)
    {
        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            return true;
        return false;
    }

    //  get month name
    public static string GetMonthName(int month)
    {
        string[] months =
        {
            "January","February","March","April","May","June",
            "July","August","September","October","November","December"
        };
        return months[month - 1];
    }

    // Method to get number of days in a month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year))
            return 29;

        return days[month - 1];
    }

    // Method to find first day of the month
    public static int GetFirstDay(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;
        return d0;
    }

    // Main Method
    static void Main()
    {
        Console.Write("Enter Month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("\n   " + GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int totalDays = GetDaysInMonth(month, year);

        // Print spaces for first day
        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        // Print days of month
        for (int day = 1; day <= totalDays; day++)
        {
            Console.Write(day.ToString().PadLeft(3) + " ");

            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
    }
}
