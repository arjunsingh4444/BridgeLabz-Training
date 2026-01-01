using System;

class Book
{
    // Public
    public string ISBN;

    // Protected
    protected string title;

    // Private
    private string author;

    // Setter for private variable
    public void SetAuthor(string author)
    {
        this.author = author;
    }

    // Getter for private variable
    public string GetAuthor()
    {
        return author;
    }
}

// Subclass
class EBook : Book
{
    public void SetBookDetails(string isbn, string title)
    {
        ISBN = isbn;       // public member
        this.title = title; // protected member
    }

    public void Display()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
    }
}

class Program
{
    static void Main()
    {
        EBook ebook = new EBook();
        ebook.SetBookDetails("ISBN123", "C# Basics");
        ebook.SetAuthor("John Doe");

        ebook.Display();
        Console.WriteLine("Author: " + ebook.GetAuthor());
    }
}
