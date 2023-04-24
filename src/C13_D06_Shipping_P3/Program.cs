Ship<IContainer> titanic = new Ship<IContainer>("Titanic", 2000);
titanic.AddContainer(new BulkContainer { Weight = 1000 });
titanic.AddContainer(new GrainContainer { FillRatio = 0.75f });
titanic.AddContainer(new GoodsContainer { ItemWeight = 100, ItemCount = 12 });

Ship<GoodsContainer> hmsBounty = new Ship<GoodsContainer>("HMS Bounty", 4000);
hmsBounty.AddContainer(new GoodsContainer { ItemWeight = 10, ItemCount = 100 });
hmsBounty.AddContainer(new GoodsContainer { ItemWeight = 80, ItemCount = 10 });
hmsBounty.AddContainer(new GoodsContainer { ItemWeight = 100, ItemCount = 10 });

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

public class GoodsContainer : IContainer
{
    public int ItemWeight { get; init; }
    public int ItemCount { get; init; }
    public int Weight => ItemWeight * ItemCount;
}

public class Ship<T> where T : IContainer
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