using System;

class BmiCalculations
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[] weight = new double[n]; //made arrays for inputs 
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter weight: ");
            weight[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter height (meters): ");
            height[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 25)
                status[i] = "Normal";
            else
                status[i] = "Overweight";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("bmi is  " + bmi[i] + " goes to  " + status[i]);
        }
    }
}
