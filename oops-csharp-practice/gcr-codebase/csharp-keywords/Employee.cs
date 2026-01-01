using System;

class Employee
{
    static string CompanyName = "Tech Corp";
    static int totalEmployees = 0;

    readonly int Id;
    string Name;
    string Designation;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }

    static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void Display(object obj)
    {
        if (obj is Employee)
        {
            Console.WriteLine(Name + " - " + Designation + " (ID: " + Id + ")");
        }
    }

    static void Main()
    {
        Employee e1 = new Employee("Arjun", 1, "Developer");
        e1.Display(e1);
        DisplayTotalEmployees();
    }
}
