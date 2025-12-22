using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        //  take Input from user like weight and height
        Console.WriteLine("Enter weight in kg:");
        double weight = double.Parse(Console.ReadLine()); //weigth 

        Console.WriteLine("Enter height in cm:");
        double heightCm = double.Parse(Console.ReadLine()); //height 

        // Convert height to meters
        double heightM = heightCm / 100;

        // Calculate BMI
        double bmi = weight / (heightM * heightM);

        // Display BMI
        Console.WriteLine("BMI is " + bmi);

        // Weight status
        if (bmi < 18.5)  //output 
            Console.WriteLine("Underweight");
        else if (bmi < 25)
            Console.WriteLine("Normal weight");
        else
            Console.WriteLine("Overweight");
    }
}
