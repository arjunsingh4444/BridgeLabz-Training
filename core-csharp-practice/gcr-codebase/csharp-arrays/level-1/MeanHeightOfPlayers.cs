using System;

class MeanHeightOfPlayers
{
    static void Main()
    {
        double[] heights = new double[11]; //input array for height 
        double sum = 0;

        for (int i = 0; i < heights.Length; i++) //loop for store height 
        {
            Console.Write("Enter heights of players ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i]; //sum of heights 
        }

        double mean = sum / 11; //mean 
        Console.WriteLine("Mean height is  = " + mean); //output 
    }
}
