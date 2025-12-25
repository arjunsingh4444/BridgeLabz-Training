using System;

class SpringSeason
{
    // Method to check spring season
    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) || //return and conditionds
               (month == 4) ||
               (month == 5) ||
               (month == 6 && day <= 20);
    }

    static void Main(string[] args)
    {
        int month = int.Parse(Console.ReadLine()); //take input 
        int day = int.Parse(Console.ReadLine());

        if (IsSpringSeason(month, day))
            Console.WriteLine("Spring Season"); //output 
        else
            Console.WriteLine("not a Spring Season");
    }
}
