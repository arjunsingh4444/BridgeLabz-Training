using System;

class Book
{
    string title;
    string author;
    double price;

    public Book(string t, string a, double p)
    {
        title = t;
        author = a;
        price = p;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Book b = new Book(title, author, price);
        b.DisplayDetails();
    }
}
