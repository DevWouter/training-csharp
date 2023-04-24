var library = new Library();
Console.WriteLine("All books:");

library.ForEachBook(book =>
{
    Console.WriteLine($"{book.Title}, {book.BSN}, {book.Author.Name}");
});

// Or use a method group:
Action<Book> writeBookWithAuthorCount = book =>
{
    Console.WriteLine($"{book.Title} written by {book.Author.Name} who has written {book.Author.Books.Count} books");
};

library.ForEachBook(writeBookWithAuthorCount);