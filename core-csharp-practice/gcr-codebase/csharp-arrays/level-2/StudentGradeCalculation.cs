using System;

class StudentGradeCalculation
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine()); //input number of person

        int[] phy = new int[n]; //create arrays for marks and percentage and grade
        int[] chem = new int[n];
        int[] math = new int[n];
        double[] percent = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++) //take input 
        {
            Console.Write("Physics marks: ");
            phy[i] = int.Parse(Console.ReadLine());

            Console.Write("Chemistry marks: ");
            chem[i] = int.Parse(Console.ReadLine());

            Console.Write("Maths marks: ");
            math[i] = int.Parse(Console.ReadLine());

            percent[i] = (phy[i] + chem[i] + math[i]) / 3.0; //calculate percentage

            if (percent[i] >= 90) grade[i] = 'A'; //calculate grades
            else if (percent[i] >= 75) grade[i] = 'B';
            else if (percent[i] >= 50) grade[i] = 'C';
            else grade[i] = 'F';
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine("Percentage is " + percent[i] + " Grade is  " + grade[i]);
    }
}
