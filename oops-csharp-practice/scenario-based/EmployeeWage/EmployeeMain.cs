namespace EmployeeWage;
using System;
class EmployeeMain{
static void Main(){
Console.WriteLine("Welcome to Employee Wage calculation program"); 
//gve program for two employees take input from user 









Console.Write("Enter Employee ID: ");
int empId = Convert.ToInt32(Console.ReadLine()); //converting input to integer

Console.Write("Enter Employee Name: ");
string empName = Console.ReadLine()?? ""; //converting input to string


Employee employee = new Employee(empId, empName); //creating an object of Employee class
IEmployee utility = new EmployeeUtilityImpl(employee); //creating an object of IEmployee interface

EmployeeMenu menu = new EmployeeMenu(utility); //creating an object of EmployeeMenu class
menu.DisplayMenu(); //displaying the menu

Console.WriteLine("Thank You"); 
}}
