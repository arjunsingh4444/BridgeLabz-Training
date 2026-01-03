using System;
using System.Collections.Generic;

class Faculty
{
    public string Name; // Name of the Faculty
}

class Department
{
    public string DeptName; //  Name of the Department
}

class University
{
    public List<Department> Departments = new List<Department>(); // List of Departments
    public List<Faculty> Faculties = new List<Faculty>(); // List of Faculties
}

class Program
{
    static void Main()
    {
        University uni = new University(); // Create a new University object 

        uni.Departments.Add(new Department { DeptName = "CS" }); // Add a new Department object to the Departments list
        uni.Faculties.Add(new Faculty { Name = "Dr. Arjun" }); // Add a new Faculty object to the Faculties list

        uni = null; // Delete the University object 
        Console.WriteLine("University deleted"); // Output message to console 
    }
}
