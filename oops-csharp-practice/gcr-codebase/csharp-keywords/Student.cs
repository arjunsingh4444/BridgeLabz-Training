using System;

class Student
{
    static string UniversityName = "ABC University"; // static variable
    static int totalStudents = 0; //     static variable

    readonly int RollNumber; //     readonly variable
    string Name; //     instance variable
    string Grade;

    public Student(string name, int roll, string grade)
    {
        this.Name = name;
        this.RollNumber = roll;
        this.Grade = grade;
        totalStudents++;
    }

    static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void Display(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine(Name + " - Roll: " + RollNumber + " - Grade: " + Grade);
        }
    }

    static void Main()
    {
        Student s1 = new Student("Arjun", 101, "A");
        s1.Display(s1);
        DisplayTotalStudents();
    }
}
