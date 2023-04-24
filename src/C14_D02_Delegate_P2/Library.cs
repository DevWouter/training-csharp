public class Author
{
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
}

public class Book
{
    public Author Author { get; set; }
    public string Title { get; set; }
    public string BSN { get; set; }
}

public class Library
{
    public List<Book> Books { get; }
    public List<Author> Authors { get; }
    public delegate bool Filter<T>(T item);
    public delegate void Action<T>(T item);

    public void ForEachBook(Action<Book> action, Filter<Book> filter)
    {
        foreach (var book in Books)
        {
            if (filter(book))
            {
                action(book);
            }
        }
    }    
    
    public void ForEachAuthor(Action<Author> action, Filter<Author> filter)
    {
        foreach (var author in Authors)
        {
            if (filter(author))
            {
                action(author);
            }
        }
    }


    public Library()
    {
        Books = new();
        Authors = new();

        var tolkien = new Author { Name = "J.R.R. Tolkien" };
        var lordOfTheRings = new Book
        {
            Author = tolkien,
            Title = "The Lord of the Rings",
            BSN = "978-0544003415"
        };

        var hobbit = new Book
        {
            Author = tolkien,
            Title = "The Hobbit",
            BSN = "978-0547928227"
        };

        var silmarillion = new Book
        {
            Author = tolkien,
            Title = "The Silmarillion",
            BSN = "978-0547928227"
        };

        tolkien.Books.Add(lordOfTheRings);
        tolkien.Books.Add(hobbit);
        tolkien.Books.Add(silmarillion);

        var martin = new Author { Name = "George R.R. Martin" };
        var gameOfThrones = new Book
        {
            Author = martin,
            Title = "A Game of Thrones",
            BSN = "978-0553593716"
        };

        var clashOfKings = new Book
        {
            Author = martin,
            Title = "A Clash of Kings",
            BSN = "978-0553593717"
        };

        var stormOfSwords = new Book
        {
            Author = martin,
            Title = "A Storm of Swords",
            BSN = "978-0553593718"
        };

        var feastForCrows = new Book
        {
            Author = martin,
            Title = "A Feast for Crows",
            BSN = "978-0553593719"
        };

        var danceWithDragons = new Book
        {
            Author = martin,
            Title = "A Dance with Dragons",
            BSN = "978-0553593720"
        };

        var windsOfWinter = new Book
        {
            Author = martin,
            Title = "The Winds of Winter",
            BSN = "978-0553593716"
        };

        var dreamOfSpring = new Book
        {
            Author = martin,
            Title = "A Dream of Spring",
            BSN = "978-0553593716"
        };

        martin.Books.Add(gameOfThrones);
        martin.Books.Add(clashOfKings);
        martin.Books.Add(stormOfSwords);
        martin.Books.Add(feastForCrows);
        martin.Books.Add(danceWithDragons);
        martin.Books.Add(windsOfWinter);
        martin.Books.Add(dreamOfSpring);

        Authors.Add(martin);
        Authors.Add(tolkien);

        Books.Add(lordOfTheRings);
        Books.Add(hobbit);
        Books.Add(silmarillion);

        Books.Add(gameOfThrones);
        Books.Add(clashOfKings);
        Books.Add(stormOfSwords);
        Books.Add(feastForCrows);
        Books.Add(danceWithDragons);
        Books.Add(windsOfWinter);
        Books.Add(dreamOfSpring);
    }
}