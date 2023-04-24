ContainerLine<Food> line = new ContainerLine<Food>();
line.Add(Food.Pizza);
line.Add(Food.Salad);
line.Add(Food.Pasta);
line.Add(Food.IceCream);

var currentContainer = line.First;
while (currentContainer != null)
{
    Console.WriteLine(currentContainer.Content);
    currentContainer = currentContainer.Next;
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
}

enum Food
{
    Pizza,
    Pasta,
    Salad,
    IceCream
}