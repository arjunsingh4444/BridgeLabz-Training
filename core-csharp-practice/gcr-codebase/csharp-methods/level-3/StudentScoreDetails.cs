using System;

class StudentScoreDetails
{
    // Method 
    
    public static int[,] GeneratePCMMarks(int students)
    {
        int[,] marks = new int[students, 3];
        Random random = new Random();

        for (int i = 0; i < students; i++)
        {
            marks[i, 0] = random.Next(10, 100); // Physics
            marks[i, 1] = random.Next(10, 100); // Chemistry
            marks[i, 2] = random.Next(10, 100); // Maths
        }
        return marks;
    }

    // Method to calculate total, average and percentage
    public static double[,] CalculateResults(int[,] marks)
    {
        int students = marks.GetLength(0);
        double[,] results = new double[students, 3];

        for (int i = 0; i < students; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    //  display scorecard
    public static void DisplayScorecard(int[,] marks, double[,] results)
    {
        Console.WriteLine("\nStudent\tPhy\tChem\tMath\tTotal\tAvg\tPercent");

        for (int i = 0; i < marks.GetLength(0); i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                marks[i, 0] + "\t" +
                marks[i, 1] + "\t" +
                marks[i, 2] + "\t" +
                results[i, 0] + "\t" +
                results[i, 1] + "\t" +
                results[i, 2]
            );
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        int[,] marks = GeneratePCMMarks(students);
        double[,] results = CalculateResults(marks);

        DisplayScorecard(marks, results);
    }
}
