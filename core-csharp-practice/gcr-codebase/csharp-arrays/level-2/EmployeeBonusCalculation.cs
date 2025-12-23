using System;

class EmployeeBonusCalculation
{
    static void Main()
    {
        double[] salary = new double[5];          // old salary
        double[] service = new double[5];         // years of service
        double[] bonus = new double[5];           // bonus amount
        double[] newSalary = new double[5];       // salary after bonus

        double totalBonus = 0, totalOld = 0, totalNew = 0;

        // Take input
        for (int i = 0; i <5; i++)
        {
            Console.Write("Enter salary of employee " + (i + 1) +"=");
            salary[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter years of service: ");
            service[i] = double.Parse(Console.ReadLine());
        }

        // Calculate bonus and salary
        for (int i = 0; i < 5; i++)
        {
            if (service[i] > 5)
                bonus[i] = salary[i] * 0.05; // 5% bonus
            else
                bonus[i] = salary[i] * 0.02; // 2% bonus

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOld += salary[i];
            totalNew += newSalary[i];
        }

        Console.WriteLine("Total Bonus = " + totalBonus);  //outputs 
        Console.WriteLine("Total Old Salary = " + totalOld);
        Console.WriteLine("Total New Salary = " + totalNew);
    }
}
