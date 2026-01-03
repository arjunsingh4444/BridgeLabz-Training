using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
}

class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public void ShowCourses()
    {
        foreach (Course c in Courses)
            Console.WriteLine(c.CourseName);
    }
}

class School
{
    public List<Student> Students = new List<Student>();
}

class Program
{
    static void Main()
    {
        Course c1 = new Course { CourseName = "Math" };
        Course c2 = new Course { CourseName = "Science" };

        Student s1 = new Student { Name = "Arjun" };
        s1.Courses.Add(c1);
        s1.Courses.Add(c2);

        School school = new School();
        school.Students.Add(s1);

        s1.ShowCourses();
    }
}
