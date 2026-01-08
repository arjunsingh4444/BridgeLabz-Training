namespace EmployeeWage;
public class EmployeeUtilityImpl:IEmployee
{

    private const int WagePerHour = 100;
    private const int FullDayHours = 8;
    private const int PartTimeHours = 2;
    private const int MaxWorkingDays = 25;
    private const int MaxWorkingHours = 150;

    private Employee employee; //reference to the Employee object
    private Random random = new Random(); //to generate random numbers
    public EmployeeUtilityImpl(Employee employee) //constructor to initialize the reference to the Employee object
    {
        this.employee = employee;
    }
    //uc1:Check Employee is Present or Absent using random
     public void CheckAttendance()
{
    
    int attendance = random.Next(0, 2); //generate random number between 0 and 1
    Console.WriteLine(attendance == 1? "Employee is Present": "Employee is Absent"); //
}

//uc 2:calculate daily employee wage
 public void CalculateDailyWage()
    {
        int dailyWage = WagePerHour * FullDayHours; //calculate wage for full day
        Console.WriteLine($"Daily Wage : {dailyWage}");
    }


//uc3:add part time employee and  wage
public void AddPartTimeEmployee()
    {
        int partTimeWage = WagePerHour * PartTimeHours;
        Console.WriteLine($"Part Time Wage : {partTimeWage}");
    }

    //uc 4:calculate wage  using switch case
     public void CalculateUsingSwitch() 
    {
        int workType = random.Next(0, 3); //generate random number between 0 and 2
        int hoursWorked = 0;

        switch (workType)
        {
            case 1:
                hoursWorked = FullDayHours;
                Console.WriteLine("Full Time Employee");
                break;

            case 2:
                hoursWorked = PartTimeHours;
                Console.WriteLine("Part Time Employee");
                break;

            default:
                Console.WriteLine("Employee is Absent");
                break;
        }

        Console.WriteLine($"Wage : {hoursWorked * WagePerHour}");
    }
//uc 5:Calculating Wages for a Month
    public void CalculateMonthlyWage()
    {
        int monthlyWage = WagePerHour * FullDayHours * MaxWorkingDays;
        Console.WriteLine($"Monthly Wage : {monthlyWage}");
    }

    //Calculate Wages till a condition of total working hours or days is reached for a month 
     public void CalculateWageWithCondition()
    {
        employee.TotalWorkingDays = 0; 
        employee.TotalWorkingHours = 0; 
        employee.TotalWage = 0;

        while (employee.TotalWorkingDays < MaxWorkingDays &&
               employee.TotalWorkingHours < MaxWorkingHours)
        {
            employee.TotalWorkingDays++;

            int workType = random.Next(0, 3); //generate random number between 0 and 2
            int hoursWorked = 0;

            switch (workType)
            {
                case 1:
                    hoursWorked = FullDayHours;
                    break;
                case 2:
                    hoursWorked = PartTimeHours;
                    break;
            }

            employee.TotalWorkingHours += hoursWorked;
            employee.TotalWage += hoursWorked * WagePerHour;
        }
        //output the total working days, hours and wage for the employee 
        Console.WriteLine("\n   Employee Wage Summary   "); 
        Console.WriteLine($"Total Working Days  : {employee.TotalWorkingDays}");
        Console.WriteLine($"Total Working Hours : {employee.TotalWorkingHours}");
        Console.WriteLine($"Total Wage          : {employee.TotalWage}");
    }
}

