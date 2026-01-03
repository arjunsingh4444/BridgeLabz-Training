using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
}

class Department
{
    public List<Employee> Employees = new List<Employee>();
}

class Company
{
    public List<Department> Departments = new List<Department>();
}

class Program
{
    static void Main()
    {
        Company comp = new Company();

        Department d1 = new Department();
        d1.Employees.Add(new Employee { Name = "Arjun" });

        comp.Departments.Add(d1);

        // When Company is deleted → all departments & employees go
        comp = null;
        Console.WriteLine("Company deleted");
    }
}
