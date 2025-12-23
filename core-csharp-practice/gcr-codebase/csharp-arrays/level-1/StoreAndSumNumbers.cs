using System;

class StoreAndSumNumbers
{
    static void Main()
    {
        double[] numbers = new double[10];  //take input array
        double total = 0.0;
        int index = 0;

        while (true) //untill true run loop
        {
            Console.Write("Enter a number: ");
            double value = double.Parse(Console.ReadLine());

            if (value <= 0 || index == 10) //if condn false 
                break;

            numbers[index] = value;
            index++;
        }

       
        for (int i = 0; i < index; i++) //calc sum 
        {
            total += numbers[i];
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Total = " + total);  //output 
    }
}
