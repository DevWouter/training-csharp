Library.Filter<Author> authorWithMoreThan3Books = item => item.Books.Count > 3;
Library.Action<Author> printAuthor = item => Console.WriteLine($"Author: {item.Name} ({item.Books.Count} books)");

Library.Action<Book> printBook = (book) => Console.WriteLine($"{book.Title}, {book.BSN}, {book.Author.Name}");
Library.Filter<Book> isAuthorJrrTolkien = (book) => book.Author.Name == "J.R.R. Tolkien";
Library.Filter<Book> hasWrittenMoreThan3Books = (book) => authorWithMoreThan3Books(book.Author);

var library = new Library();

Console.WriteLine("Books by J.R.R. Tolkien:");
library.ForEachBook(printBook, isAuthorJrrTolkien);

Console.WriteLine("Book has author who has written more than 3 books");
library.ForEachBook(printBook, hasWrittenMoreThan3Books);

Console.WriteLine("Author who has written more than 3 books:");
library.ForEachAuthor(printAuthor, authorWithMoreThan3Books);