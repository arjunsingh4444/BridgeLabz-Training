namespace EmployeeWage;
using System;

public sealed class EmployeeMenu // sealed class for employee menu
{
    private readonly IEmployee employeeUtility; //interface for employeeutility

    public EmployeeMenu(IEmployee employeeUtility) //constructor for employee menu
    {
        this.employeeUtility = employeeUtility; //assigning interface to employeeUtilityc
    }

    public void DisplayMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n    Employee Wage Menu ");
            Console.WriteLine("1. Check Attendance"); //uc1
             Console.WriteLine("2. Daily Wage");   //uc2
              Console.WriteLine("3. Part Time Wage"); //uc3
               Console.WriteLine("4. Switch Case"); //uc4 
               Console.WriteLine("5. Monthly Wage"); //uc5 
                Console.WriteLine("6. Wage with Condition"); //uc6
            Console.WriteLine("0. Exit");                     //for exit fron program 
            Console.Write("Enter choice: ");
            //take choice input from user
            choice = Convert.ToInt32(Console.ReadLine());  

            switch (choice)
            {
                case 1:
                    employeeUtility.CheckAttendance(); //calling methods of employeeUtility class
                    break;
                case 2:
                    employeeUtility.CalculateDailyWage(); 
                    break;
                case 3:
                    employeeUtility.AddPartTimeEmployee(); 
                    break;
                case 4:
                    employeeUtility.CalculateUsingSwitch();
                    break;
                case 5:
                    employeeUtility.CalculateMonthlyWage();
                    break;
                case 6:
                    employeeUtility.CalculateWageWithCondition();
                    break;
                
            }

        } while (choice != 0);
    }
}
