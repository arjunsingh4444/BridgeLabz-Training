using System;

class Course
{
    // Instance variables
    public string courseName;
    public int duration;
    public double fee;

    // Class variable
    public static string instituteName = "BridgeLabz";

    public Course(string name, int duration, double fee)
    {
        this.courseName = name;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute: " + instituteName);
    }

    // Class method
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}

class Program
{
    static void Main()
    {
        Course c1 = new Course("C#", 3, 15000);
        c1.DisplayCourseDetails();

        Course.UpdateInstituteName("Tech Academy");

        c1.DisplayCourseDetails();
    }
}
