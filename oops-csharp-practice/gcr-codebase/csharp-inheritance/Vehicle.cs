using System;

// Superclass
class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Speed: {MaxSpeed}, Fuel: {FuelType}");
    }
}

// Car class
class Car : Vehicle
{
    public int SeatCapacity;

    public override void DisplayInfo()
    {
        base.DisplayInfo(); // call the DisplayInfo method of the superclass
        Console.WriteLine("Seats: " + SeatCapacity); // add the SeatCapacity property to the Car class
    }
}

// Truck class
class Truck : Vehicle
{
    public int PayloadCapacity;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload: " + PayloadCapacity);
    }
}

// Motorcycle class
class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Sidecar: " + HasSidecar);
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles =
        {
            new Car { MaxSpeed = 180, FuelType = "Petrol", SeatCapacity = 5 },
            new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 3000 },
            new Motorcycle { MaxSpeed = 150, FuelType = "Petrol", HasSidecar = false }
        };

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}
