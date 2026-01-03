using System;

class Course
{
    public string CourseName; 

class Professor // nested class
{
    public string Name; 

    public void AssignProfessor(Course c)
    {
        Console.WriteLine(Name + " teaches " + c.CourseName);
    }
}

class Student // nested class
{
    public string Name;

    public void EnrollCourse(Course c) // method to enroll in a course
    {
        Console.WriteLine(Name + " enrolled in " + c.CourseName); // prints the name of the student and the name of the course
    }
}

class Program
{
    static void Main()
    {
        Course c = new Course { CourseName = "C#" }; // creating an instance of the Course class

        Student s = new Student { Name = "Arjun" }; // creating an instance of the Student class
        Professor p = new Professor { Name = "Dr. Rahul" }; // creating an instance of the Professor class

        s.EnrollCourse(c); // calling the EnrollCourse method of the Student class
        p.AssignProfessor(c); // calling the AssignProfessor method of the Professor class
    }
}
