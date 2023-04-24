// No longer allowed
// hip.IContainer>(100_000); 

Ship<BulkContainer> titanic = new Ship<BulkContainer>("Titanic", 2000);
titanic.AddContainer(new BulkContainer { Weight = 1000 });
titanic.AddContainer(new GrainContainer { FillRatio = 0.75f });
// The following is no longer allowed since a goods container is part of a different type hierarchy
// titanic.AddContainer(new GoodsContainer { ItemWeight = 100, ItemCount = 12 });

Ship<GoodsContainer> hmsBounty = new Ship<GoodsContainer>("HMS Bounty", 4000);
hmsBounty.AddContainer(new GoodsContainer { ItemWeight = 10, ItemCount = 100 });
hmsBounty.AddContainer(new GoodsContainer { ItemWeight = 80, ItemCount = 10 });
hmsBounty.AddContainer(new GoodsContainer { ItemWeight = 100, ItemCount = 10 });

titanic.PrintInfoSheet();
hmsBounty.PrintInfoSheet();

public class BulkContainer : Ship<BulkContainer>.IContainer
{
    public int Weight { get; init; }
}

public class GrainContainer : BulkContainer
{
    private const int EmptyGrainContainerWeight = 100;
    private const int FullGrainContainerWeight = 1000;

    /// <summary>
    /// How full is the container?
    /// </summary>
    public float FillRatio { get; init; }

    public int Weight => (int)(EmptyGrainContainerWeight + (FullGrainContainerWeight - EmptyGrainContainerWeight) * FillRatio);
}

public class GoodsContainer : Ship<GoodsContainer>.IContainer
{
    public int ItemWeight { get; init; }
    public int ItemCount { get; init; }
    public int Weight => ItemWeight * ItemCount;
}

public class Ship<T> where T : Ship<T>.IContainer
{
    public interface IContainer
    {
        public int Weight { get; }
    }

    public string Name { get; }
    public int MaxWeight { get; }
    public int CurrentWeight { get; private set; }
    public bool Overloaded => CurrentWeight > MaxWeight;

    public Ship(string name, int maxWeight)
    {
        Name = name;
        MaxWeight = maxWeight;
    }

    public void AddContainer(T container)
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