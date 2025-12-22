using System;

class SimpleCalculator
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter first number:");
        double first = double.Parse(Console.ReadLine()); //input. one num 

        
        Console.WriteLine("Enter second number:");
        double second = double.Parse(Console.ReadLine()); //input second num

    
        Console.WriteLine("Enter operator (+, -, *, /):");  //operators 
        string opr = Console.ReadLine();

        // Perform operation 
        switch (opr)
        {
            case "+":
                Console.WriteLine(first + second);
                break;

            case "-":
                Console.WriteLine(first - second);
                break;

            case "*":
                Console.WriteLine(first * second);
                break;

            case "/":
                if (second != 0)
                    Console.WriteLine(first / second);
                else
                    Console.WriteLine("Division by zero not allowed");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
