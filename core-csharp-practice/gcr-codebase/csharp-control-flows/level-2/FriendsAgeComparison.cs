using System;

class FriendsAgeComparison
{
    static void Main(string[] args)
    {
        // Input ages
        Console.WriteLine("Enter Amar's age:");
        int amarAge = int.Parse(Console.ReadLine()); //amar age 

        Console.WriteLine("Enter Akbar's age:");
        int akbarAge = int.Parse(Console.ReadLine()); //akbar age

        Console.WriteLine("Enter Anthony's age:");
        int anthonyAge = int.Parse(Console.ReadLine()); //anthony age

        // Input heights
        Console.WriteLine("Enter Amar's height:");
        int amarHeight = int.Parse(Console.ReadLine());  //amar height

        Console.WriteLine("Enter Akbar's height:");
        int akbarHeight = int.Parse(Console.ReadLine());    //   akbar height

        Console.WriteLine("Enter Anthony's height:");
        int anthonyHeight = int.Parse(Console.ReadLine()); //anthony height

        // Find youngest
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        Console.WriteLine("Youngest age is=" +youngestAge);

        // Find tallest
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        Console.WriteLine("Tallest height is :" + tallestHeight);
    }
}
