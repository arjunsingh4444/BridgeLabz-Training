using System;

class RandomGenerate
{
    static int[] Generate4DigitRandomArray(int size) //methjods
    {
        Random rand = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(1000, 10000);

        return arr;
    }

    public static double[] FindAvgMinMax(int[] numbers)
    {
        int min = numbers[0], max = numbers[0], sum = 0;

        foreach (int n in numbers) //loop through the array
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }

        return new double[] { (double)sum / numbers.Length, min, max }; //return 
    }
}
