using System;
 public class AgeOfHarry
 {
     public static void Main()
     {
         Console.WriteLine("What is the age of Harry?");
        //  int age = int.Parse(Console.ReadLine());
        int birthYear=2000;  //birth year of Harry

         int currentYear= 2024;  //current year

         int currentAge = currentYear - birthYear;  //current age of Harry
         Console.WriteLine("Harry is " + currentAge + " years old.");
        
     }
 }