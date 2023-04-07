// ┌ Type of variable (Animal/Dog/Cat)
// │   ┌ Name of variable
// │   │   ┌ Assign operator
// │   │   │ ┌ Create an instance
// │   │   │ │   ┌ Type of instance (Animal/Dog/Cat)
Animal ape = new Animal("King Kong");
Dog    dog = new Dog("Scooby-Doo", "Mystery Inc.");
Cat    cat = new Cat("Garfield", "Lasagna");

// NOTE: Tom (from Tom and Jerry) is an instance of a Cat, but we store it in a Animal variable.
//       This is called "down-casting" since we are casting from a more specific type to a more general type.
Animal tom = new Cat("Tom", "Jerry");

// We can store all the animals and supertypes in a List<Animal> since Animal is the most general type.
List<Animal> animals = new List<Animal>();
animals.Add(ape);
animals.Add(dog);
animals.Add(cat);
animals.Add(tom);

// In this list only dogs are allowed.
List<Dog> dogs = new List<Dog>();
dogs.Add(dog);

// In this list only cats are allowed.
List<Cat> cats = new List<Cat>();
cats.Add(cat);

// NOTE: We can't add a Tom to the a List<Cats> since the value-type is a Animal, which is too general.
// cats.Add(tom);

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
//       ┌ We know that the List<Cat> contains `Cat`, but here we also down-casting it to Animal
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