using System;

class EmployeeBonus
{
       public static double[,] GenerateEmployeeData(int employees)//meyhod 
    {
        double[,] data = new double[employees, 2];
        Random random = new Random();

        for (int i = 0; i < employees; i++)
        {
            data[i, 0] = random.Next(10000, 99999); // 5-digit salary
            data[i, 1] = random.Next(1, 11);        // years of service (1–10)
        }
        return data;
    }

    // Method to calculate bonus and new salary
    public static double[,] CalculateBonus(double[,] employeeData)
    {
        int employees = employeeData.GetLength(0);
        double[,] result = new double[employees, 3];

        for (int i = 0; i < employees; i++)
        {
            double salary = employeeData[i, 0];
            double years = employeeData[i, 1];
            double bonus;

            if (years > 5)
                bonus = salary * 0.05; // 5% bonus
            else
                bonus = salary * 0.02; // 2% bonus

            result[i, 0] = salary;
            result[i, 1] = bonus;
            result[i, 2] = salary + bonus;
        }
        return result;
    }

    //  display salary table and totals
    public static void DisplayResult(double[,] salaryData)
    {
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;

        Console.WriteLine("\nEmp\tOldSalary\tBonus\t\tNewSalary");

        for (int i = 0; i < salaryData.GetLength(0); i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                salaryData[i, 0] + "\t\t" +
                salaryData[i, 1] + "\t\t" +
                salaryData[i, 2]
            );

            totalOldSalary += salaryData[i, 0];
            totalBonus += salaryData[i, 1];
            totalNewSalary += salaryData[i, 2];
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);//output total old salary
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }

    static void Main()
    {
        int numberOfEmployees = 10;

        double[,] employeeData = GenerateEmployeeData(numberOfEmployees);
        double[,] salaryResult = CalculateBonus(employeeData);

        DisplayResult(salaryResult);
    }
}
