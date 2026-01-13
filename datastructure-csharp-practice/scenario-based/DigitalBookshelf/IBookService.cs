// Interface defines the allowed operations
public interface IBookService
{
    void AddBook(string title, string author); // Add a new book to the shelf
    void SortBooksAlphabetically(); 
    void SearchByAuthor(string author);
    void ExportBooks();
}
