using System;

//  Base class
class Course
{
    public string CourseName;
    public int Duration; // in hours

    // Method to display basic course details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " hours");
    }
}

// OnlineCourse inherits Course
class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    // Override method to add online course details
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // call Course method
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + IsRecorded);
    }
}

// PaidOnlineCourse inherits OnlineCourse
class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;

    // Override method to add payment details
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // call OnlineCourse method
        Console.WriteLine("Fee:" + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}

class Program
{
    static void Main()
    {
        // Create object of the most derived class
        PaidOnlineCourse course = new PaidOnlineCourse();

        // Set values
        course.CourseName = "C# Full Stack";
        course.Duration = 40;
        course.Platform = "Udemy";
        course.IsRecorded = true;
        course.Fee = 5000;
        course.Discount = 10;

        // Display all details
        course.DisplayDetails();
    }
}
