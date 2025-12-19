using System;

class PenDistribution
{
    static void Main()
    {
        int totalPens = 14;  //pens 
        int students = 3;   //students

        int pensPerStudent = totalPens / students;  //pens per student
        int remainingPens = totalPens % students;  //remaning pens 

        Console.WriteLine(pensPerStudent + " pens per student" + " and " + remainingPens + " pens remaining"); //output the result
    }
}
