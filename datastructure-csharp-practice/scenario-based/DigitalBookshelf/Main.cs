using System;

// Program starts here
class Program
{
    static void Main()
    {
        IBookService bookService = new BookService(); // Loose coupling
        Menu.ShowMenu(bookService);            // Start menu
    }
}
