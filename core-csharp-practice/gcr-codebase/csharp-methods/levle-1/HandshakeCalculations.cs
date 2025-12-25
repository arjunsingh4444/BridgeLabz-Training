using System;

class HandshakeCalculations
{
    
    static int CalculateHandshakes(int numberOfStudents) //method
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2; //return method
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(students); //method call 

        Console.WriteLine("Maximum number of handshakes: " + handshakes); //output 
    }
}
