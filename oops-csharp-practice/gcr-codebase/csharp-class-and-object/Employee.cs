using System;

class Employee
{
    // Attributes
    public string name;
    public int id;
    public double salary;

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name   : " + name);
        Console.WriteLine("Employee ID     : " + id);
        Console.WriteLine("Employee Salary : " + salary);
    }

    static void Main()
    {
        // Create object of Employee class
        Employee emp = new Employee();

        // Assign values
        emp.name = "Arjun Singh";
        emp.id = 101;
        emp.salary = 45000;

        // Display details
        emp.DisplayDetails();
    }
}
