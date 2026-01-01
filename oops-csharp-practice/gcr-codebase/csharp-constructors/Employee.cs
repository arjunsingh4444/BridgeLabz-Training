using System;

class Employee
{
    // Public
    public int employeeID;

    // Protected
    protected string department;

    // Private
    private double salary;

    // Public method to modify salary
    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

// Subclass
class Manager : Employee
{
    public void SetDetails(int id, string dept)
    {
        employeeID = id;      // public
        department = dept;   // protected
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        manager.SetDetails(201, "IT");
        manager.SetSalary(75000);

        manager.Display();
        Console.WriteLine("Salary: " + manager.GetSalary());
    }
}
