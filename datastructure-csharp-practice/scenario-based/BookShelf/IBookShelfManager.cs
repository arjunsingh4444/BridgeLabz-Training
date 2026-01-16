
// Defines operations for library management
public interface IBookShelfManager
{
    void AddBook(string genre, string bookName);
    void BorrowBook(string genre, string bookName);
    void ShowCatalog();
}
