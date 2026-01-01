using System;

class Patient
{
    static string HospitalName = "City Hospital";
    static int totalPatients = 0;

    readonly int PatientID;
    string Name;
    int Age;
    string Ailment;

    public Patient(string name, int age, string ailment, int id)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = id;
        totalPatients++;
    }

    static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    public void Display(object obj)
    {
        if (obj is Patient)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine(Name + " (" + Age + ") - " + Ailment);
            Console.WriteLine("Patient ID: " + PatientID);
        }
    }

    static void Main()
    {
        Patient p1 = new Patient("Arjun", 22, "Fever", 101);
        p1.Display(p1);
        GetTotalPatients();
    }
}
