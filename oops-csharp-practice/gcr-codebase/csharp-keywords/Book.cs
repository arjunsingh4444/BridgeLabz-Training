using System;

class Book
{
    static string LibraryName = "City Library"; // static variable

    readonly string ISBN; // readonly variable
    string Title;
    string Author;

    public Book(string title, string author, string isbn) // constructor
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    static void DisplayLibraryName() // static method
    {
        Console.WriteLine("Library: " + LibraryName); // accessing static variable
    }

    public void Display(object obj) // method to display book details
    {
        if (obj is Book) // checking if object is of type Book
        {
            Console.WriteLine("Title: " + Title);   // accessing instance variables
            Console.WriteLine("Author: " + Author); // accessing instance variables
            Console.WriteLine("ISBN: " + ISBN);
        }
    }

    static void Main() 
    {
        Book b1 = new Book("C# Basics", "John", "ISBN123"); // creating object of Book class
        DisplayLibraryName(); // calling static method
        b1.Display(b1); // calling instance method to display book details
    }
}
