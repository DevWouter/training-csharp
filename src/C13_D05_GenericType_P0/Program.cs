var numberContainer = new Container<int>(1234);
var stringContainer = new Container<string>("Hello World!");
var foodContainer = new Container<Food>(Food.Pizza);
var computerContainer = new Container<Computer>(new Computer("Microsoft", "Surface Pro 7", 999));

Console.WriteLine("numberContainer.Content:   " + numberContainer.Content);
Console.WriteLine("stringContainer.Content:   " + stringContainer.Content);
Console.WriteLine("foodContainer.Content:     " + foodContainer.Content);
Console.WriteLine("computerContainer.Content: " + computerContainer.Content);

public class Container<T>
{
    public T Content { get; set; }

    public Container(T content)
    {
        Content = content;
    }
}

public enum Food
{
    Pizza,
    Pasta,
    Salad
}

public class Computer
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }

    public Computer(string brand, string model, int price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Brand} {Model} {Price}";
    }
}