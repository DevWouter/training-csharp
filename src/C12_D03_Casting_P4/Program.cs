// We know store all the variables in a List<Animal> since Animal is the most general type.
// This means that we loose type-information about the specific type of the variable.
List<Animal> animals = new List<Animal>();
animals.Add(new Animal("King Kong"));
animals.Add(new Dog("Scooby-Doo", "Mystery Inc."));
animals.Add(new Cat("Garfield", "Lasagna"));
animals.Add(new Cat("Tom", "Jerry"));


// So how can we get the specific type of the variable back?
List<Dog> dogs = new List<Dog>();
List<Cat> cats = new List<Cat>();


////////////////////////////////////////////////////////////////////////////////////////////////
// Option 3: Safe casting with pattern variables
foreach (var animal in animals)
{
    // Using pattern variables we can check if the variable is of a specific type and assign it to a variable of that type.
    // It only works within the scope of the if-statement.
    // ┌ Variable
    // │      ┌ is-keyword
    // │      │  ┌ The target type (Dog)
    // │      │  │   ┌ A new variable dog/cat is created and assigned the value of animal if the cast is possible
    if(animal is Dog dog) dogs.Add(dog);
    if(animal is Cat cat) cats.Add(cat);
}


////////////////////////////////////////////////////////////////////////////////////////////////
// Printing the lists
Console.WriteLine("\nAnimals:");
foreach (Animal animal in animals)
{
    Console.WriteLine("- " + animal);
}

Console.WriteLine("\nDogs:");
foreach (Dog animal in dogs)
{
    Console.WriteLine("- " + animal);
}

Console.WriteLine("\nCats:");
foreach (Animal animal in cats)
{
    Console.WriteLine("- " + animal);
}

public class Animal
{
    public string Name { get; set; }
    public Animal(string name) => Name = name;
    public override string ToString() => $"{Name} (an animal)";
}

public class Dog : Animal
{
    public string WorkingPlace { get; set; }
    public override string ToString() => $"{Name} (a dog that works at {WorkingPlace})";
    public Dog(string name, string workingPlace) : base(name) => WorkingPlace = workingPlace;
}

public class Cat : Animal
{
    public string FavoriteFood { get; set; }
    public override string ToString() => $"{Name} (a cat that enjoys eating {FavoriteFood})";
    public Cat(string name, string favoriteFood) : base(name) => FavoriteFood = favoriteFood;
}