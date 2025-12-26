using System;

class TimeZones
{
    static void Main()
    {
        // Get current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        // Get time zone information
        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert UTC time to different time zones
        Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcTime, gmt));
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime, ist));
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcTime, pst));
    }
}
