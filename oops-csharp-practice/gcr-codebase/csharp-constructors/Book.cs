using System;

class Book
{
    // Private fields (Encapsulation)
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        // 'this' keyword avoids ambiguity
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void Display()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
    }
}

class book
{
    static void Main()
    {
        Book b1 = new Book();
        Book b2 = new Book("C# Basics", "John", 499);

        b1.Display();
        b2.Display();
    }
}
