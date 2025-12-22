using System;

class StudentGrade
{
    static void Main(string[] args)
    {
        // Input
        Console.WriteLine("Enter Physics marks:");
        int physics = int.Parse(Console.ReadLine());  //phy input 

        Console.WriteLine("Enter Chemistry marks:");
        int chemistry = int.Parse(Console.ReadLine());  //chem input

        Console.WriteLine("Enter Maths marks:");
        int maths = int.Parse(Console.ReadLine());  //maths input

        // Calculate average
        double average = (physics + chemistry + maths) / 3.0;

        // Display average
        Console.WriteLine("verage Marks is :" + average);

        // Grade calculation
        if (average >= 75)
            Console.WriteLine("Grade: A | Remarks: Excellent");
        else if (average >= 60)
            Console.WriteLine("Grade: B | Remarks: Very Good");
        else if (average >= 50)
            Console.WriteLine("Grade: C | Remarks: Good");
        else
            Console.WriteLine("Grade: D | Remarks: Needs Improvement");
    }
}
