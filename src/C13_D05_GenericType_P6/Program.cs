// Requirement:
// [x] Ships must carry containers
// [x] Ships can only containers of a certain kind
// [x] Ships must carry an specific kind of container

Ship<BulkContainer> bulkContainerShip = new Ship<BulkContainer>(100_000);
Ship<GoodsContainer> goodsContainerShip = new Ship<GoodsContainer>(100_000);

bulkContainerShip.AddContainer(new BulkContainer(10_000));
bulkContainerShip.AddContainer(new BulkContainer(20_000));

goodsContainerShip.AddContainer(new GoodsContainer(1_000, 10));
goodsContainerShip.AddContainer(new GoodsContainer(2_000, 20));

// The following will no longer work.
// A bulk container ship can only carry bulk containers and a goods container ship can only carry goods containers.
// bulkContainerShip.AddContainer(new GoodsContainer(1_000, 10));

// The following will no longer work.
// Ship<Ship<???>.IContainer> carryAllShip = new Ship<IContainer>(100_000);
// carryAllShip.AddContainer(new BulkContainer(10_000));
// carryAllShip.AddContainer(new GoodsContainer(2_000, 20));


public class BulkContainer : Ship<BulkContainer>.IContainer
{
    private const int OwnWeight = 8_000;
    public int Weight => OwnWeight + CoalWeight;
    public int CoalWeight { get; private set; }

    public BulkContainer(int coalWeight)
    {
        CoalWeight = coalWeight;
    }
}

public class GoodsContainer : Ship<GoodsContainer>.IContainer
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

public class Ship<TContainer>
    where TContainer : Ship<TContainer>.IContainer
{
    public int MaxWeight { get; private set; }
    public int CurrentWeight { get; private set; }
    public List<TContainer> Containers { get; private set; } = new();
    
    public interface IContainer
    {
        int Weight { get; }
    }

    public Ship(int maxWeight)
    {
        MaxWeight = maxWeight;
    }

    public void AddContainer(TContainer container)
    {
        if (CurrentWeight + container.Weight > MaxWeight)
            throw new InvalidOperationException("Ship is too heavy!");

        Containers.Add(container);
        CurrentWeight += container.Weight;
    }
}