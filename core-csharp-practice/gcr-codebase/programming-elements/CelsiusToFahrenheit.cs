using System;
 public class CelsiusToFahrenheit
 {
     public static void Main(string[] args)
     {
         Console.Write("Enter temperature in Celsius ");
         double celsius = double.Parse(Console.ReadLine());  //input celsius 
         double fahrenheit = (celsius * 9/5) + 32;      //convert celsius to fahrenheit
         Console.WriteLine("Temperature in Fahrenheit " + fahrenheit);  //output fahrenheit
     }
 }