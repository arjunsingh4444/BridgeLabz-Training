using System;

class BmiUsing2DArray
{
    static void Main()
    {
      
        Console.Write("Enter number of persons: "); //take input 
        int n = int.Parse(Console.ReadLine());

       
        double[,] data = new double[n, 3]; //create twoD arr

       
        string[] status = new string[n];

        // Take input
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));

            // Input weight
            Console.Write("Enter weight  ");
            data[i, 0] = double.Parse(Console.ReadLine());

            // Input height
            Console.Write("Enter height ");
            data[i, 1] = double.Parse(Console.ReadLine());

            // Calculate BMI
            data[i, 2] = data[i, 0] / (data[i, 1] * data[i, 1]);

            // Decide BMI status
            if (data[i, 2] < 18.5)
                status[i] = "Underweight";
            else if (data[i, 2] < 25)
                status[i] = "Normal";
            else
                status[i] = "Overweight";
        }

        // Display result
        Console.WriteLine("BMI");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "Weight: " + data[i, 0] +
                " Height: " + data[i, 1] +
                " BMI: " + data[i, 2] +
                " Status: " + status[i]
            );
        }
    }
}
