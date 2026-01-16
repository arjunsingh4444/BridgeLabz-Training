
// Represents a single book in a linked list
public class BookNode
{
    public string BookName;
    public BookNode Next;

    public BookNode(string bookName)
    {
        BookName = bookName;
        Next = null;
    }
}
