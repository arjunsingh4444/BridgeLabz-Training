using System;

// Interface for flying birds
interface IFlyable //
{
    void Fly(); // Method to fly
} 

// Interface for swimming birds
interface ISwimmable //
{
    void Swim(); // Method to swim
}

// Base class
abstract class Bird // Abstract class Bird
{
    public string Name; // Name of the bird
    public int Age;

    public Bird(string name, int age) // Constructor of Bird class with name and age parameters 
    {
        Name = name;
        Age = age;
    }

    public abstract void Display(); // Abstract method to display details of the bird
}

// Derived classes
class Eagle : Bird, IFlyable // Eagle class inherits from Bird class and implements IFlyable interface
{
    public Eagle(string name, int age) : base(name, age) { } // Constructor of Eagle class with name and age parameters 

    public void Fly() // Method to fly
    {
        Console.WriteLine($"{Name} (Eagle) is flying high.");
    }

    public override void Display()
    {
        Console.WriteLine($"Eagle - Name: {Name}, Age: {Age}");
    }
}

class Sparrow : Bird, IFlyable // Sparrow class inherits from Bird class and implements IFlyable interface
{
    public Sparrow(string name, int age) : base(name, age) { } // Constructor of Sparrow class with name and age parameters 

    public void Fly()
    {
        Console.WriteLine($"{Name} (Sparrow) is flying.");
    }

    public override void Display()
    {
        Console.WriteLine($"Sparrow - Name: {Name}, Age: {Age}");
    }
}

class Duck : Bird, ISwimmable
{
    public Duck(string name, int age) : base(name, age) { } // Constructor of Duck class with name and age parameters 

    public void Swim()
    {
        Console.WriteLine($"{Name} (Duck) is swimming.");
    }

    public override void Display()
    {
        Console.WriteLine($"Duck - Name: {Name}, Age: {Age}");
    }
}

class Penguin : Bird, ISwimmable
{
    public Penguin(string name, int age) : base(name, age) { }

    public void Swim()
    {
        Console.WriteLine($"{Name} (Penguin) is swimming.");
    }

    public override void Display()
    {
        Console.WriteLine($"Penguin - Name: {Name}, Age: {Age}");
    }
}

class Seagull : Bird, IFlyable, ISwimmable // Seagull class inherits from Bird class and implements IFlyable and ISwimmable interfaces
{
    public Seagull(string name, int age) : base(name, age) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} (Seagull) is flying.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} (Seagull) is swimming.");
    }

    public override void Display()
    {
        Console.WriteLine($"Seagull - Name: {Name}, Age: {Age}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Console.Write("Enter number of birds: "); // Taking input from user for number of birds
        int n = int.Parse(Console.ReadLine());

        Bird[] birds = new Bird[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n1.Eagle  2.Sparrow  3.Duck  4.Penguin  5.Seagull");
            Console.Write("Choose bird type: ");
            int choice = int.Parse(Console.ReadLine()); // Taking input from user for bird type

            Console.Write("Enter Name: ");
            string name = Console.ReadLine(); // Taking input from user for name 

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine()); // Taking input from user for age

            switch (choice)
            {
                case 1: birds[i] = new Eagle(name, age); break;
                case 2: birds[i] = new Sparrow(name, age); break;
                case 3: birds[i] = new Duck(name, age); break;
                case 4: birds[i] = new Penguin(name, age); break;
                case 5: birds[i] = new Seagull(name, age); break;
                default:
                    Console.WriteLine("Invalid choice");
                    i--;
                    break;
            }
        }

        Console.WriteLine("\n--- Bird Activities ---");
        foreach (Bird b in birds)
        {
            b.Display();

            if (b is IFlyable fly)
                fly.Fly();

            if (b is ISwimmable swim)
                swim.Swim();

            Console.WriteLine();
        }
    }
}