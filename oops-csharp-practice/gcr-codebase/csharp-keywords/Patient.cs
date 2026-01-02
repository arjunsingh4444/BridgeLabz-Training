using System;

class Patient
{
    static string HospitalName = "City Hospital"; // static variable
    static int totalPatients = 0; // static variable

    readonly int PatientID;
    string Name;
    int Age;
    string Ailment;

    public Patient(string name, int age, string ailment, int id) // constructor
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = id;
        totalPatients++;
    }

    static void GetTotalPatients() // static method
    {
        Console.WriteLine("Total Patients: " + totalPatients); // static method
    }

    public void Display(object obj) // method to display patient details
    {
        if (obj is Patient) // checking if object is of type Patient
        {
            Console.WriteLine("Hospital: " + HospitalName); // accessing static variable
            Console.WriteLine(Name + " (" + Age + ") - " + Ailment); // accessing instance variables
            Console.WriteLine("Patient ID: " + PatientID); // accessing instance variable
        }
    }

    static void Main() 
    {
        Patient p1 = new Patient("Arjun", 22, "Fever", 101); // creating object of Patient class
        p1.Display(p1); // calling Display method of Patient class
        GetTotalPatients(); // calling GetTotalPatients method of Patient class
    }
}
