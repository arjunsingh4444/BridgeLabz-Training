using System;   
public class AreaOfCircle{   
   public static void Main(){   
      double radius, area;   //take input from user   
      Console.Write("Enter the radius of the circle");     //ask user to input radius   
      radius = Console.ReadLine();   
      area = Math.PI * radius * radius;   //area. 
      Console.WriteLine("The area of the circle is: " + area);   
   }   
}