using System;

class Book
{
    private string title;
    private string author;
    private double price;
    private bool isAvailable; // Boolean variable to check if the book is available or not

    public Book(string title, string author, double price) // Constructor
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = true;
    }

    public void BorrowBook() // Method to borrow the book
    {
        if (isAvailable) // Check if the book is available
        {
            isAvailable = false; // Set the book as borrowed
            Console.WriteLine("Book borrowed successfully."); // Display message
        }
        else
        {
            Console.WriteLine("Book is not available.");
        }
    }

    public void Display() // Method to display the book details
    {
        Console.WriteLine($"Title: {title}, Available: {isAvailable}");
    }
}

class bookBorrow
{
    static void Main()
    {
        Book book = new Book("OOP in C#", "James", 350); // Create an object of Book class
        book.Display(); // Display the book details
        book.BorrowBook(); // Borrow the book
        book.Display(); // Display the book details again
    }
}
