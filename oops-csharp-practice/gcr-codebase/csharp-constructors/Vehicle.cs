using System;

class Vehicle
{
    // Instance variables (unique for each vehicle)
    public string ownerName;
    public string vehicleType;

    // Class variable (same for all vehicles)
    public static double registrationFee = 5000;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }

    // Class method
    public static void UpdateRegistrationFee(double fee)
    {
        registrationFee = fee;
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Arjun", "Bike");
        v1.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(6000);

        v1.DisplayVehicleDetails();
    }
}
