using System;

class Person
{
    private string name;
    private int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class personTest
{
    static void Main()
    {
        Person p1 = new Person("Alice", 25);
        Person p2 = new Person(p1);

        p1.Display();
        p2.Display();
    }
}
