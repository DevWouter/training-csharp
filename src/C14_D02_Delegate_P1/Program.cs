Library.BookAction printBook = (book) =>
{
    Console.WriteLine($"{book.Title}, {book.BSN}, {book.Author.Name}");
};

Library.BookFilter isAuthorJrrTolkien = (book) =>
{
    return book.Author.Name == "J.R.R. Tolkien";
};

Library.BookFilter hasWrittenMoreThan3Books = (book) => book.Author.Books.Count > 3;

var library = new Library();

Console.WriteLine("Books by J.R.R. Tolkien:");
library.ForEachBook(printBook, isAuthorJrrTolkien);


Console.WriteLine("Book has author who has written more than 3 books");
library.ForEachBook(printBook, hasWrittenMoreThan3Books);