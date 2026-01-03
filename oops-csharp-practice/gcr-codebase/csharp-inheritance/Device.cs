using System;

// Superclass (Parent Class)
class Device
{
    // Common properties for all devices
    public string DeviceId;
    public string Status;   // ON  or  OFF

    // Method to display basic device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

// Subclass (Child Class)
class Thermostat : Device
{
    // Additional property specific to Thermostat
    public int TemperatureSetting;

    // Override method to display thermostat details
    public override void DisplayStatus()
    {
        // Call parent class method
        base.DisplayStatus();

        // Display extra thermostat information
        Console.WriteLine("Temperature: " + TemperatureSetting + "°C");
    }
}

class Program
{
    static void Main()
    {
        // Create object of Thermostat
        Thermostat t = new Thermostat();

        // Set values
        t.DeviceId = "THERMO-101";
        t.Status = "ON";
        t.TemperatureSetting = 24;

        // Display device status
        t.DisplayStatus();
    }
}
