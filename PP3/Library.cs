public class Library
{
    private readonly List<Book> books = new();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book? FindBook(int id)
    {
        return books.FirstOrDefault(book => book.Id == id);
    }

    public void BorrowBook(int id)
    {
        Book? book = FindBook(id);

        if (book == null)
        {
            Console.WriteLine("Ошибка: книга не найдена.");
            return;
        }

        if (!book.IsAvailable)
        {
            Console.WriteLine("Ошибка: книга уже выдана.");
            return;
        }

        book.IsAvailable = false;
        Console.WriteLine($"Книга \"{book.Title}\" выдана.");
    }

    public void ReturnBook(int id)
    {
        Book? book = FindBook(id);

        if (book == null)
        {
            Console.WriteLine("Ошибка: книга не найдена.");
            return;
        }

        if (book.IsAvailable)
        {
            Console.WriteLine("Ошибка: книга не была выдана.");
            return;
        }

        book.IsAvailable = true;
        Console.WriteLine($"Книга \"{book.Title}\" возвращена.");
    }
}
