using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter salary:");
        double salary = double.Parse(Console.ReadLine());  //input salary 

        Console.WriteLine("Enter years of service:");
        int years = int.Parse(Console.ReadLine());  // input year 
  
        double bonus = 0;

        if (years > 5) //condition 
        {
            bonus = salary * 0.05;
        }

        Console.WriteLine("Bonus amount is " + bonus);  ///output 
    }
}
