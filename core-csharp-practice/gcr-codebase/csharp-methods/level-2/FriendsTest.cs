using System;

class FriendsTest
{
    static int FindYoungest(int[] ages) //method of finf yong 
    {
        return Math.Min(ages[0], Math.Min(ages[1], ages[2]));
    }

    static int FindTallest(int[] heights) //method of find tall height 
    {
        return Math.Max(heights[0], Math.Max(heights[1], heights[2]));
    }

    static void Main()
    {
        int[] ages = new int[3]; //take inpit array
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Youngest Age: " + FindYoungest(ages)); //outputs 
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
    }
}
