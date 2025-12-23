using System;

class FizzBuzzProgram
{
    static void Main()
    {
        Console.Write("Enter a  number: ");
        int number = int.Parse(Console.ReadLine()); //take a number 

        string[] result = new string[number + 1]; //array to store the result

        for (int i = 1; i <= number; i++) //loop to iterate through the numbers
        {
            if (i % 3 == 0 && i % 5 == 0) //conditions 
                result[i] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i] = "Fizz";
            else if (i % 5 == 0)
                result[i] = "Buzz";
            else
                result[i] = i.ToString();
        }

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine( result[i]);
        }
    }
}
