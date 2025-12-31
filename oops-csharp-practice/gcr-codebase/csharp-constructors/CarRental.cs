using System;

class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;

    // Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;

        // Keep logic simple in constructor
        CalculateCost();
    }

    // Private method to encapsulate logic
    private void CalculateCost()
    {
        double dailyRate = 1000; // Fixed rate per day
        totalCost = rentalDays * dailyRate;
    }

    public void Display()
    {
        Console.WriteLine($"{customerName} rented {carModel} for {rentalDays} days");
        Console.WriteLine("Total Cost: " + totalCost);
    }
}

class Program
{
    static void Main()
    {
        CarRental rental = new CarRental("Amit", "Honda City", 4);
        rental.Display();
    }
}
