using System;

class TemperatureAnalyzer
{
    static void Main()
    {
        // Create 2D array for 7 days and 24 hours
        float[,] temp = new float[7, 24];

        // Take temperature input from user
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("\nEnter temperatures for Day " + (day + 1));

            for (int hour = 0; hour < 24; hour++)
            {
                Console.Write("Hour " + (hour + 1) + ": ");
                temp[day, hour] = float.Parse(Console.ReadLine());
            }
        }

        float hottest = temp[0, 0];
        float coldest = temp[0, 0];
        int hottestDay = 1;
        int coldestDay = 1;

        // Calculate average, hottest and coldest day
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                sum += temp[day, hour];
            }

            float avg = sum / 24;
            Console.WriteLine("Day " + (day + 1) + " Average = " + avg);

            if (avg > hottest)
            {
                hottest = avg;
                hottestDay = day + 1;
            }

            if (avg < coldest)
            {
                coldest = avg;
                coldestDay = day + 1;
            }
        }

        Console.WriteLine("\nHottest Day: Day " + hottestDay);
        Console.WriteLine("Coldest Day: Day " + coldestDay);
    }
}
