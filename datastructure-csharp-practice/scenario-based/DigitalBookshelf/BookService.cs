using System;

// Implements book-related operations using fixed-size array
public class BookService : IBookService //abstraction of IBookService
{
    private string[] books = new string[50];  //encapsulation of Max 50 books
    private int count = 0; // Current number of books
 
    // Add a book
    public void AddBook(string title, string author)
    {
        if (count >= books.Length)
        {
            Console.WriteLine("Book array is full. Cannot add more books.");
            return;
        }

    

        books[count] = $"{title} - {author}"; // Format book title with author
        count++;
        Console.WriteLine("Book added successfully.");
    }

    // Sort books alphabetically using simple bubble sort
    public void SortBooksAlphabetically()
    {
        if (count == 0)
        {
            Console.WriteLine("No books available to sort.");
            return;
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (string.Compare(books[j], books[j + 1], StringComparison.OrdinalIgnoreCase) > 0) // Compare book titles in case-insensitive 
                {
                    string temp = books[j]; // Swap books
                    books[j] = books[j + 1]; 
                    books[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Books sorted alphabetically.");
    }
    public void DisplayBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books available to display.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(books[i]);
        }
    }

    // Search books by author
    public void SearchByAuthor(string author) 
    {
        if (count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        bool found = false;

        for (int i = 0; i < count; i++) // Loop through all books
        {
            string[] parts = books[i].Split('-'); // Split book title and author
            if (parts.Length == 2)
            {
                string bookAuthor = parts[1].Trim(); // Trim whitespace from author name
                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase)) // Compare author names in case-insensitive
                {
                    Console.WriteLine(books[i]); // Print book title
                    found = true; // Set found flag to true
                }
            }
        }

        if (!found) // If no books found for this author
            Console.WriteLine("No books found for this author.");
    }
    
}
