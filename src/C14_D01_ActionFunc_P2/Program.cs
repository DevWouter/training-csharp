var library = new Library();

Console.WriteLine("All books:");
library.ForEachBook((book, author) =>
{
    Console.WriteLine($"{book.Title}, {book.BSN}, {author.Name}");
});


// Or use a method group:
Action<Book, Author> writeBookWithAuthorCount = (book, author) =>
{
    Console.WriteLine($"{book.Title} written by {author.Name} who has written {author.Books.Count} books");
};

library.ForEachBook(writeBookWithAuthorCount);