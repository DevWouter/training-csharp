var numberContainer = new Container<int>();
numberContainer.Content = 1234;

var stringContainer = new Container<string>();
stringContainer.Content = "Hello World!";

var foodContainer = new Container<Food>();
foodContainer.Content = Food.Pizza;

Console.WriteLine("numberContainer.Content: " + numberContainer.Content);
Console.WriteLine("stringContainer.Content: " + stringContainer.Content);
Console.WriteLine("foodContainer.Content: " + foodContainer.Content);

public class Container<T>
{
    public T Content { get; set; }
}

public enum Food
{
    Pizza,
    Pasta,
    Salad
}