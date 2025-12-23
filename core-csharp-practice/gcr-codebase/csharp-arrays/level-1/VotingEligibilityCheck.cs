using System;

class VotingEligibilityCheck
{
    static void Main()
    {
        int[] ages = new int[10];

        
        for (int i = 0; i < ages.Length; i++) //take input 
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine()); // I/P
        }

       
        for (int i = 0; i < ages.Length; i++)//  // Check voting eligibility
        {
            if (ages[i] < 0)
                Console.WriteLine("Invalid age");
            else if (ages[i] >= 18)
                Console.WriteLine( ages[i] + " can vote");
            else
                Console.WriteLine( ages[i] + " cannot vote");
        }
    }
}
