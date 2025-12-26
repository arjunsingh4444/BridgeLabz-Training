using System;

class BasicCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: "); //take input 
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose operation (+ - * /): ");
        char opr = Console.ReadLine()[0]; //take operator

        switch (opr)
        {
            case '+':
                Console.WriteLine("Result: " + Add(a, b));
                break;
            case '-':
                Console.WriteLine("Result: " + Subtract(a, b));
                break;
            case '*':
                Console.WriteLine("Result: " + Multiply(a, b));
                break;
            case '/':
                Console.WriteLine("Result: " + Divide(a, b));
                break;
            default:
                Console.WriteLine("Invalid Operation");
                break;
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
}
