Ship bulkContainerShip = new Ship(100_000);
Ship goodsContainerShip = new Ship(100_000);

bulkContainerShip.AddContainer(new BulkContainer(10_000));
bulkContainerShip.AddContainer(new BulkContainer(20_000));

goodsContainerShip.AddContainer(new GoodsContainer(1_000, 10));
goodsContainerShip.AddContainer(new GoodsContainer(2_000, 20));

// Sadly the following is now also allowed
bulkContainerShip.AddContainer(new GoodsContainer(1_000, 10));

public class BulkContainer : IContainer
{
    private const int OwnWeight = 8_000;
    public int Weight => OwnWeight + CoalWeight;
    public int CoalWeight { get; private set; }

    public BulkContainer(int coalWeight)
    {
        CoalWeight = coalWeight;
    }
}

public class GoodsContainer : IContainer
{
    private const int OwnWeight = 10_000;
    public int Weight => OwnWeight + (ItemWeight * ItemCount);
    public int ItemWeight { get; private set; }
    public int ItemCount { get; private set; }

    public GoodsContainer(int itemWeight, int itemCount)
    {
        ItemWeight = itemWeight;
        ItemCount = itemCount;
    }
}

public interface IContainer
{
    int Weight { get; }
}

public class Ship
{
    public int MaxWeight { get; private set; }
    public int CurrentWeight { get; private set; }
    public List<IContainer> Containers { get; private set; } = new();

    public Ship(int maxWeight)
    {
        MaxWeight = maxWeight;
    }

    public void AddContainer(IContainer container)
    {
        if (CurrentWeight + container.Weight > MaxWeight)
            throw new InvalidOperationException("Ship is too heavy!");

        Containers.Add(container);
        CurrentWeight += container.Weight;
    }
}