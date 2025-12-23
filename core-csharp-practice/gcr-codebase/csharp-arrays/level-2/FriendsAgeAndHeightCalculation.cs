using System;

class FriendsAgeAndHeightCalculation
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" }; //all friends names
        int[] age = new int[3]; //age 
        double[] height = new double[3]; //height 

        // Inputs taken 
        for (int i = 0; i < 3; i++) //loop to take input 
        {
            Console.Write("Enter age of " + names[i] + "= "); //age input 
            age[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + "="); //height input 
            height[i] = double.Parse(Console.ReadLine());
        }

        int youngest = 0;
        int tallest = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest])
                youngest = i;

            if (height[i] > height[tallest])
                tallest = i;
        }

        Console.WriteLine("Youngest one is  " + names[youngest]);
        Console.WriteLine("Tallest one is  " + names[tallest]);
    }
}
