using System;

class VoteEligibility
{
    static void Main(string[] args)
    {
        // Input age
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());

        // Check voting condition
        if (age >= 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}
