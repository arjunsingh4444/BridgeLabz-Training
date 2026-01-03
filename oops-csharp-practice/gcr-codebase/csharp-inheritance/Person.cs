using System;

// Superclass
class Person
{
    public string Name;
    public int Age;
}

// Teacher class
class Teacher : Person
{
    public string Subject;

    public void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
    }
}

// Student class
class Student : Person
{
    public string Grade;

    public void DisplayRole()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}

// Staff class
class Staff : Person
{
    public string Department;

    public void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
    }
}

class Program
{
    static void Main()
    {
        Teacher t = new Teacher
        {
            Name = "Arjun",
            Age = 30,
            Subject = "Computer Science"
        };

        t.DisplayRole();
        Student s = new  Student
        {
            Name = "Arjun",
            Age = 30,
            Grade = "12th"
        };
        s.DisplayRole();
    }
}
