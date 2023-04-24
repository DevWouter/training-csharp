Ship titanic = new Ship("Titanic", 2000);
titanic.AddContainer(new BulkContainer { Weight = 1000 });
titanic.AddContainer(new BulkContainer { Weight = 750 });
titanic.AddContainer(new BulkContainer { Weight = 1200 });

Ship hmsBounty = new Ship("HMS Bounty", 4000);
hmsBounty.AddContainer(new BulkContainer { Weight = 1000 });
hmsBounty.AddContainer(new BulkContainer { Weight = 800 });
hmsBounty.AddContainer(new BulkContainer { Weight = 1000 });

titanic.PrintInfoSheet();
hmsBounty.PrintInfoSheet();

public interface IContainer
{
    public int Weight { get; }
}

public class BulkContainer : IContainer
{
    public int Weight { get; init; }
}

public class Ship
{
    public string Name { get; }
    public int MaxWeight { get; }
    public int CurrentWeight { get; private set; }
    public bool Overloaded => CurrentWeight > MaxWeight;

    public Ship(string name, int maxWeight)
    {
        Name = name;
        MaxWeight = maxWeight;
    }

    public void AddContainer(IContainer container)
    {
        CurrentWeight += container.Weight;
    }

    public void PrintInfoSheet()
    {
        Console.WriteLine("Ship name:      " + Name);
        Console.WriteLine("Max weight:     " + MaxWeight);
        Console.WriteLine("Current weight: " + CurrentWeight);
        Console.WriteLine("Overloaded:     " + Overloaded);
        Console.WriteLine();
    }
}