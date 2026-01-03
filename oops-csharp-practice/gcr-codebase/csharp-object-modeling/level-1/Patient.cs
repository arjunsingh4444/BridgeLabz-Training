using System;

class Patient
{
    public string Name; // Property to store patient name
}

class Doctor // Class to represent a doctor
{
    public string Name;

    public void Consult(Patient p) // Method to consult a patient
    {
        Console.WriteLine(Name + " is consulting " + p.Name); // Printing the message to the console
    }
}

class Program
{
    static void Main()
    {
        Doctor d = new Doctor { Name = "Dr. Rahul" }; // Creating a doctor object and assigning a name to it
        Patient p = new Patient { Name = "Arjun" }; // Creating a patient object and assigning a name to it
 
        d.Consult(p); // Calling the Consult method of the Doctor class to consult the patient object
        Console.ReadLine(); // Waiting for user input before closing the console window
    }
}
