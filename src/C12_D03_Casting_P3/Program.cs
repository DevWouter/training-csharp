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
// Option 1: Safe casting
foreach (var animal in animals)
{
    Console.WriteLine("Attempting to add to the dogs list: " + animal);

    // Using `as` we can try to cast the variable to a specific type. If the cast is not possible, the variable will be null.
    //                 ┌ Is the variable of type Animal
    //                 │      ┌ as-keyword
    //                 │      │  ┌ The target type (Dog)
    Dog? possibleDog = animal as Dog;

    // So we need to check if the cast was successful.
    if (possibleDog != null)
    {
        // And if it was, we can add it to the list.
        dogs.Add(possibleDog);
    }

    if (animal is Cat)
    {
        cats.Add((Cat)animal);
    }
}


////////////////////////////////////////////////////////////////////////////////////////////////
// Option 2: Type checking and unsafe casting
foreach (var animal in animals)
{
    Console.WriteLine("Attempting to add to the cats list: " + animal);

    // Using `is` we can check if the variable is of a specific type. It will be true if the cast is possible, and false if it is not.
    //           ┌ Is the variable of type Animal
    //           │      ┌ is-keyword
    //           │      │  ┌ The target type (Cat)
    bool isCat = animal is Cat;

    if (isCat)
    {
        //              ┌ We know that the variable is of type Cat, so we can force the cast, if this would fail the program would throw
        //              │    InvalidOperationException. This is another form of up-casting.
        Cat forcedCat = (Cat)animal;
        cats.Add(forcedCat);
    }
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