namespace EmployeeWage;
using System;

public class Employee
{
  //employee id,name
    private int EmployeeId { get; set; } // private access modifiers
    private string EmployeeName { get; set; } //
   
    public int TotalWorkingDays { get; set; } // public access modifiers
    public int TotalWorkingHours { get; set; }
    public int TotalWage { get; set; }
      public Employee(int employeeId,string empName) // constructor
    {
        EmployeeId = employeeId; 
        EmployeeName=empName;
    }

    //use. to string meyhod 
    public override string ToString()
    {
        return $"Employee Id: {EmployeeId}, Employee Name: {EmployeeName}, Total Working Days: {TotalWorkingDays}, Total Working Hours: {TotalWorkingHours}, Total Wage: {TotalWage}";
    }
}




   

