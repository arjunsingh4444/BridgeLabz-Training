using System;

class BmiCalculations
{
    // Method 
    static double CalculateBMI(double weight, double heightCm)
    {
        double heightMeter = heightCm / 100;   // convert cm to meter
        return weight / (heightMeter * heightMeter);
    }

    // Method to find BMI 
    static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 25)
            return "Normal";
        else if (bmi < 30)
            return "Overweight";
        else
            return "Obese";
    }

    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("\nPerson " + i);

            // Take weight 
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            // Take height 
            Console.Write("Enter height (cm): ");
            double height = double.Parse(Console.ReadLine());

            // Calculate BMI
            double bmi = CalculateBMI(weight, height);

            // Get BMI status
            string status = GetBMIStatus(bmi);

            // result
            Console.WriteLine("Weight: " + weight + " kg");
            Console.WriteLine("Height: " + height + " cm");
            Console.WriteLine("BMI: " + bmi);
            Console.WriteLine("Status: " + status);
        }
    }
}
