ContainerLine<Food> line = new ContainerLine<Food>();
line.Add(Food.Pizza);
line.Add(Food.Salad);
line.Add(Food.Pasta);
line.Add(Food.IceCream);

foreach (var food in line.GetValues())
{
    Console.WriteLine(food);
}

public class Container<T>
{
    public T Content { get; set; }
    public Container<T>? Next { get; set; }
}

public class ContainerLine<T>
{
    public Container<T>? First { get; set; }
    public Container<T>? Last { get; set; }

    public void Add(T value)
    {
        var newContainer = new Container<T> { Content = value };
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

    public IEnumerable<T> GetValues()
    {
        var currentContainer = First;
        while (currentContainer != null)
        {
            yield return currentContainer.Content;
            currentContainer = currentContainer.Next;
        }
    }
}

enum Food
{
    Pizza,
    Pasta,
    Salad,
    IceCream
}