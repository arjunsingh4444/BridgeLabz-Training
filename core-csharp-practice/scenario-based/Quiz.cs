//It compares the student’s answers with the correct answers using case-insensitive matching, 
//calculates the score and percentage, and then displays whether the student PASS or FAIL based on a 50% cutoff.

using System;

class Quiz
{
    static void Main()
    {
        string[] correctAnswers = { "A", "B", "C", "D", "A" }; // correct answers
        string[] studentAnswers = new string[5]; // student answers

        int score = 0;

        Console.WriteLine("Enter answers (A/B/C/D):");

        for (int i = 0; i < 5; i++) // loop through 5 questions
        {
            Console.Write("Question " + (i + 1) + ": "); // display question number
            studentAnswers[i] = Console.ReadLine();

            if (correctAnswers[i].Equals(studentAnswers[i], // check if answer is correct
                StringComparison.OrdinalIgnoreCase)) //for case-insensitive comparison
            {
                score++;
            }
        }

        double percentage = (score / 5.0) * 100; // calculate percentage

        Console.WriteLine("\nScore = " + score + "/5");   //score  putout
        Console.WriteLine("Percentage = " + percentage + "%"); //percentage output 

        if (percentage >= 50) //ckeck percentage conditiion for pass or fail 
            Console.WriteLine("Result = PASS"); //pass output 
        else
            Console.WriteLine("Result = FAIL");  //fail output 
    }
}
