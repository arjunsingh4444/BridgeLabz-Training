 using System;

// Base class
class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
    }
}

// Manager class
class Manager : Employee
{
    public int TeamSize;

    public override void DisplayDetails()
    {
        base.DisplayDetails(); // call parent method usiing base keyword
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

// Developer class
class Developer : Employee
{
    public string ProgrammingLanguage;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Language: " + ProgrammingLanguage);
    }
}

// Intern class
class Intern : Employee
{
    public string InternshipDuration;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Duration: " + InternshipDuration);
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager
        {
            Name = "Arjun",
            Id = 1,
            Salary = 50000,
            TeamSize = 5
        };

        m.DisplayDetails();
    }
}
