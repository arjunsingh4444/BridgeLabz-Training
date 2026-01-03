using System;

// Superclass
class Vehicle
{
    public string Model;
    public int MaxSpeed;
}

// Interface
interface Refuelable
{
    void Refuel();
}

// ElectricVehicle class
// Inherits Vehicle only
class ElectricVehicle : Vehicle
{
    public void Charge()
    {
        Console.WriteLine("Electric vehicle is charging.");
    }
}

// PetrolVehicle class
// Inherits Vehicle + Implements Refuelable
class PetrolVehicle : Vehicle, Refuelable
{
    public void Refuel()
    {
        Console.WriteLine("Petrol vehicle is refueling.");
    }
}

class Program
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle
        {
            Model = "Tesla",
            MaxSpeed = 200
        };

        ev.Charge();

        PetrolVehicle pv = new PetrolVehicle
        {
            Model = "Honda",
            MaxSpeed = 180
        };

        pv.Refuel();
    }
}
