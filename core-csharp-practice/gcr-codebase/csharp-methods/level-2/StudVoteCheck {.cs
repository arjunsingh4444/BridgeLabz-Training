using System;

class StudVoteCheck
{
    public static bool CanStudentVote(int age) //method 
    {
        if (age < 0) return false;
        return age >= 18;
    }

    static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote");
        }
    }
}
