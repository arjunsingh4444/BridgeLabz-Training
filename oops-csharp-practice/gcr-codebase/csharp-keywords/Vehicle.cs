using System;

class Vehicle
{
    static int RegistrationFee = 500;

    readonly string RegistrationNumber;
    string OwnerName;
    string VehicleType;

    public Vehicle(string owner, string type, string regNo)
    {
        this.OwnerName = owner;
        this.VehicleType = type;
        this.RegistrationNumber = regNo;
    }

    static void UpdateRegistrationFee(int fee)
    {
        RegistrationFee = fee;
    }

    public void Display(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine(OwnerName + " owns " + VehicleType);
            Console.WriteLine("Reg No: " + RegistrationNumber);
            Console.WriteLine("Fee: " + RegistrationFee);
        }
    }

    static void Main()
    {
        Vehicle v1 = new Vehicle("Arjun", "Bike", "MH12AB1234");
        UpdateRegistrationFee(700);
        v1.Display(v1);
    }
}
