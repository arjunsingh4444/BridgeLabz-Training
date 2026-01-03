using System;
using System.Collections.Generic;

class Book
{
    public string Title; // public property
    public string Author;

    public Book(string title, string author) // constructor
    {
        Title = title;
        Author = author;
    }
}

class Library
{
    public List<Book> Books = new List<Book>(); // public property

    public void AddBook(Book book) // public method to add books to the library
    {
        Books.Add(book); // add the book to the list of books
    }
 
    public void ShowBooks() // public method to show all the books in the library
    {
        foreach (Book b in Books) // loop through the list of books
        {
            Console.WriteLine(b.Title + " by " + b.Author); // print the title and author of each book
        }
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book("C# Basics", "Arjun");
        Book b2 = new Book("OOP Concepts", "Rahul");

        Library lib = new Library(); // create a new library object
        lib.AddBook(b1); // add the books to the library 
        lib.AddBook(b2); // add the books to the library

        lib.ShowBooks();
    }
}
