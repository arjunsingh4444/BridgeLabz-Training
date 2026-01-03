using System;

class Book
{
    public string Title; // title of the book
    public int PublicationYear; //
}

class Author : Book // Author inherits from Book
{
    public string Name; // name of the author
    // public string Bio;

    public void DisplayInfo() // method to display author information
    {
        Console.WriteLine($"{Title} ({PublicationYear}) by {Name}"); //
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author // creating an instance of Author class
        {
            Title = "C# Basics", 
            PublicationYear = 2024,
            Name = "Arjun"
        };

        a.DisplayInfo(); // calling the DisplayInfo method of Author class
    }
}
