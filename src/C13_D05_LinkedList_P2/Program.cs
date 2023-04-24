Container<Food> foodContainer1 = new Container<Food>() { Content = Food.Pizza };
Container<Food> foodContainer2 = new Container<Food>() { Content = Food.Salad };
Container<Food> foodContainer3 = new Container<Food>() { Content = Food.Pasta };
Container<Food> foodContainer4 = new Container<Food>() { Content = Food.IceCream };

Container<int> numberContainer = new Container<int>() { Content = 1234 };

// Linking the containers
foodContainer1.Next = foodContainer2;
foodContainer2.Next = foodContainer3;
foodContainer3.Next = foodContainer4;
// foodContainer4.Next = numberContainer; // This will cause a compile error

var currentContainer = foodContainer1;
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

enum Food
{
    Pizza,
    Pasta,
    Salad,
    IceCream
}