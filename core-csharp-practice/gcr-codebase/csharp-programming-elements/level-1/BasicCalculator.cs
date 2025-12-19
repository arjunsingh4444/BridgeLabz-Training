using System;

class BasicCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());// input of number 1 from user

        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());   //second number input from user

        Console.WriteLine($"Addition: {number1 + number2}");  //addition of two numbers
        Console.WriteLine($"Subtraction: {number1 - number2}");  //sun=btraction of two nmbees 
        Console.WriteLine($"Square: {number1 * number1}");  //square of a number
        Console.WriteLine($"Multiplication: {number1 * number2}");//multiplication 
        Console.WriteLine($"Division: {number1 / number2}");  //division of two  numbersv
        
    }
}
