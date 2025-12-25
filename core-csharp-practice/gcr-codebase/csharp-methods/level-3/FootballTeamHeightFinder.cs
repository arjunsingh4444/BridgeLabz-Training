using System;

class FootballTeamHeightFinder
{
    // Method to generate random heights for players
    static int[] GenerateRandomHeights(int size)
    {
        int[] heights = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            // Generate height between 150 to 250 
            heights[i] = random.Next(150, 251);
        }

        return heights;
    }

    // Method to find sum of heights
    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find mean height
    static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find shortest height
    static int FindShortest(int[] heights)
    {
        int shortest = heights[0];

        foreach (int height in heights)
        {
            if (height < shortest)
                shortest = height;
        }

        return shortest;
    }

    // Method to find tallest height
    static int FindTallest(int[] heights)
    {
        int tallest = heights[0];

        foreach (int height in heights)
        {
            if (height > tallest)
                tallest = height;
        }

        return tallest;
    }

    static void Main()
    {
        // Football team has 11 players
        int[] heights = GenerateRandomHeights(11);

        Console.WriteLine("Player Heights =");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }

        Console.WriteLine("\n\nShortest Height: " + FindShortest(heights));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
        Console.WriteLine("Mean Height: " + FindMean(heights));
    }
}
