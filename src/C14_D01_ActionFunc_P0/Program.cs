var library = new Library();
Console.WriteLine("All books:");
foreach (var book in library.Books)
{
    Console.WriteLine($"{book.Title}, {book.BSN}, {book.Author.Name}");
}
