using System;

// Superclass
class Person
{
    public string Name;
    public int Id;
}

// Interface (acts like a contract)
interface Worker
{
    void PerformDuties(); // method without body
}

// Chef class
// Inherits Person + Implements Worker
class Chef : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Chef is cooking food.");
    }
}

// Waiter class
// Inherits Person + Implements Worker
class Waiter : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving food.");
    }
}

class Program
{
    static void Main()
    {
        Chef chef = new Chef
        {
            Name = "Arjun",
            Id = 101
        };

        chef.PerformDuties();

        Waiter waiter = new Waiter
        {
            Name = "Rahul",
            Id = 102
        };

        waiter.PerformDuties();
    }
}
