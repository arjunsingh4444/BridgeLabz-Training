using System;

class MaximumHandshakes
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());  //take input from user 

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;   //handshakes 
 
        Console.WriteLine($"The maximum number of handshakes is {handshakes}");  //output of result 
    }
}
