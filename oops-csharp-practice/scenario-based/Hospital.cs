using System;
using System.Collections.Generic;

// INTERFACES 
interface IPatient
{
    void DisplayInfo();
}

interface IPayable
{
    double CalculateBill();
}

//  DOCTOR
class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public List<Patient> Patients { get; set; } = new List<Patient>();

    public Doctor(int id, string name, string spec)
    {
        DoctorId = id;
        Name = name;
        Specialization = spec;
    }

    public void AddPatient(Patient p)
    {
        Patients.Add(p);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Doctor | ID:{DoctorId} Name:{Name} Specialization:{Specialization}");
    }

    public void DisplayPatients()
    {
        Console.WriteLine($"Patients under Dr. {Name}:");
        if (Patients.Count == 0)
        {
            Console.WriteLine("No patients assigned.");
            return;
        }
        foreach (var p in Patients)
        {
            p.DisplayInfo();
        }
    }
}

//  PATIENT 
abstract class Patient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Doctor AssignedDoctor { get; set; }

    protected Patient(int id, string name, int age, Doctor doctor)
    {
        PatientId = id;
        Name = name;
        Age = age;
        AssignedDoctor = doctor;
    }

    public abstract void DisplayInfo();
}

// INPATIENT 
class InPatient : Patient, IPayable
{
    public int DaysAdmitted { get; set; }
    public double ChargePerDay = 2000;

    public InPatient(int id, string name, int age, int days, Doctor doc)
        : base(id, name, age, doc)
    {
        DaysAdmitted = days;
    }

    public double CalculateBill()
    {
        return DaysAdmitted * ChargePerDay;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"InPatient | ID:{PatientId} Name:{Name} Age:{Age} Days:{DaysAdmitted} Doctor:{AssignedDoctor.Name}");
    }
}

//  OUTPATIENT 
class OutPatient : Patient, IPayable
{
    public double ConsultationFee = 500;

    public OutPatient(int id, string name, int age, Doctor doc)
        : base(id, name, age, doc)
    {
    }

    public double CalculateBill()
    {
        return ConsultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"OutPatient | ID:{PatientId} Name:{Name} Age:{Age} Doctor:{AssignedDoctor.Name}");
    }
}

//  BILL
class Bill
{
    public static void Generate(IPayable p)
    {
        Console.WriteLine($"Total Bill Amount: {p.CalculateBill()}");
    }
}

//  UTILITY 
static class Utility
{
    public static int ReadInt(string msg)
    {
        Console.Write(msg);
        return int.Parse(Console.ReadLine());
    }

    public static string ReadString(string msg)
    {
        Console.Write(msg);
        return Console.ReadLine();
    }
}

//  MAIN =================
class Hospital
{
    static List<Doctor> doctors = new List<Doctor>();
    static List<Patient> patients = new List<Patient>();

    static Doctor SelectDoctor()
    {
        Console.WriteLine("Available Doctors:");
        foreach (var d in doctors)
            Console.WriteLine($"{d.DoctorId} - {d.Name}");

        int id = Utility.ReadInt("Select Doctor ID: ");
        return doctors.Find(d => d.DoctorId == id);
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Hospital Management System ---");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Add InPatient");
            Console.WriteLine("3. Add OutPatient");
            Console.WriteLine("4. Doctor-wise Patient List");
            Console.WriteLine("5. Generate Patient Bill");
            Console.WriteLine("6. Exit");

            int choice = Utility.ReadInt("Enter choice: ");

            switch (choice)
            {
                case 1:
                    Doctor d = new Doctor(
                        Utility.ReadInt("Doctor ID: "),
                        Utility.ReadString("Name: "),
                        Utility.ReadString("Specialization: ")
                    );
                    doctors.Add(d);
                    Console.WriteLine("Doctor added successfully.");
                    break;

                case 2:
                    Doctor doc1 = SelectDoctor();
                    if (doc1 == null) { Console.WriteLine("Invalid doctor"); break; }

                    InPatient ip = new InPatient(
                        Utility.ReadInt("Patient ID: "),
                        Utility.ReadString("Name: "),
                        Utility.ReadInt("Age: "),
                        Utility.ReadInt("Days Admitted: "),
                        doc1
                    );
                    patients.Add(ip);
                    doc1.AddPatient(ip);
                    Console.WriteLine("InPatient added.");
                    break;

                case 3:
                    Doctor doc2 = SelectDoctor();
                    if (doc2 == null) { Console.WriteLine("Invalid doctor"); break; }

                    OutPatient op = new OutPatient(
                        Utility.ReadInt("Patient ID: "),
                        Utility.ReadString("Name: "),
                        Utility.ReadInt("Age: "),
                        doc2
                    );
                    patients.Add(op);
                    doc2.AddPatient(op);
                    Console.WriteLine("OutPatient added.");
                    break;

                case 4:
                    Doctor doc = SelectDoctor();
                    if (doc != null) doc.DisplayPatients();
                    break;

                case 5:
                    int pid = Utility.ReadInt("Enter Patient ID: ");
                    Patient p = patients.Find(x => x.PatientId == pid);
                    if (p is IPayable pay)
                        Bill.Generate(pay);
                    else
                        Console.WriteLine("Patient not found or not payable");
                    break;

                case 6:
                    return;
            }
        }
    }
}