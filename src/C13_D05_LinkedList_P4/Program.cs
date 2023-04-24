ContainerLine line = new ContainerLine();
line.Add(Food.Pizza);
line.Add(Food.Salad);
line.Add(Food.Pasta);
line.Add(Food.IceCream);

foreach (var food in line.GetValues())
{
    Console.WriteLine(food);
}

public class Container
{
    public Food Content { get; set; }
    public Container? Next { get; set; }
}

public class ContainerLine
{
    public Container? First { get; set; }
    public Container? Last { get; set; }

    public void Add(Food value)
    {
        var newContainer = new Container { Content = value };
        if (Last != null)
        {
            Last.Next = newContainer;
            Last = newContainer;
        }
        else
        {
            First = newContainer;
            Last = newContainer;
        }
    }

    public IEnumerable<Food> GetValues()
    {
        var currentContainer = First;
        while (currentContainer != null)
        {
            yield return currentContainer.Content;
            currentContainer = currentContainer.Next;
        }
    }
}

public enum Food
{
    Pizza,
    Pasta,
    Salad,
    IceCream
}