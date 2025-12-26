using System;
using System.Globalization;
class DateAndTimeDemo

{
static void Main()
{
// Step 1: Input date in dd-MM-yyyy format
Console.WriteLine("Enter a date (dd-MM-yyyy): ");


string inputDate = Console.ReadLine();
// Step 2: Parse input date using DateTime.ParseExact
DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy",
CultureInfo.InvariantCulture);
// Step 3: Find the day of the week
Console.WriteLine("Day of the Week: " + date.DayOfWeek);
// Step 4: Calculate the difference between input date and current date
DateTime currentDate = DateTime.Now;
TimeSpan difference = currentDate - date;
Console.WriteLine("Days between input date and current date: " +
difference.Days);
// Step 5: Display the current date and time in a formatted way
Console.WriteLine("Current Date and Time: " +
currentDate.ToString("dd-MM-yyyy HH:mm:ss"));
}
}