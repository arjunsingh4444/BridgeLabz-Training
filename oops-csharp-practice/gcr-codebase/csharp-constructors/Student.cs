using System;

class Student
{
    // Public member
    public int rollNumber;

    // Protected member
    protected string name;

    // Private member
    private double cgpa;

    // Public method to set CGPA
    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }

    // Public method to get CGPA
    public double GetCGPA()
    {
        return cgpa;
    }
}

// Subclass
class PostgraduateStudent : Student
{
    public void SetName(string name)
    {
        this.name = name; // protected member accessible
    }

    public void Display()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        PostgraduateStudent pg = new PostgraduateStudent();
        pg.rollNumber = 101;
        pg.SetName("Arjun");
        pg.SetCGPA(8.4);

        pg.Display();
        Console.WriteLine("CGPA: " + pg.GetCGPA());
    }
}
