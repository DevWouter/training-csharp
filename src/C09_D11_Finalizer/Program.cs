// Explain garbage collection

CreateAndSayHi(1, "Microsoft");

// Force the garbage collector to run. It basically tells the garbage collector to remove all objects that are not referenced anymore.
System.GC.Collect(); 

CreateAndSayHi(2, "AdventureWorks");

void CreateAndSayHi(int id, string name)
{
    var shop = new Store(id, name);
    shop.PrintIntroduction();
}

public class Store
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Store(int id, string name)
    {
        Id = id;
        Name = name;
        Console.WriteLine($"The store with id {Id} is created");
    }

    public void PrintIntroduction()
    {
        Console.WriteLine($"Welcome to {Name} store");
    }
    
    // This is a destructor
    ~Store()
    {
        // Clean up unmanaged resources
        Console.WriteLine($"The destructor is called, store with id {Id} is destroyed");
    }
}