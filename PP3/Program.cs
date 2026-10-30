Library library = new();

library.AddBook(new Book { Id = 1, Title = "Война и мир", Author = "Лев Толстой" });
library.AddBook(new Book { Id = 2, Title = "Преступление и наказание", Author = "Фёдор Достоевский" });

Console.WriteLine("1. Обычная выдача:");
library.BorrowBook(1);

Console.WriteLine("2. Повторная выдача:");
library.BorrowBook(1);

Console.WriteLine("3. Возврат невыданной книги:");
library.ReturnBook(2);

Console.WriteLine("4. Обычный возврат:");
library.ReturnBook(1);

Console.WriteLine("5. Выдача несуществующей книги:");
library.BorrowBook(99);
