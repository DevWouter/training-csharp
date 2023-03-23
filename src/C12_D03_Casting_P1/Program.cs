// NOTE: To keep all the code on screen, we will be using expression body syntax a lot more.
//       If you see the following code
//
//       """
//       public int MemberMethod() => 14;
//       public int GetOnlyProperty => 23;
//       """
//
//       It is the same as
//
//       """
//       public int MemberMethod()
//       {
//          return 14;
//       }
//       public int GetOnlyProperty
//       {
//          get
//          {
//              return 23;
//          }
//       }
//       """

// ┌ Type of variable (Animal/Dog/Cat)
// │   ┌ Name of variable
// │   │  ┌ Assign operator
// │   │  │ ┌ Create an instance
// │   │  │ │   ┌ Type of instance (Animal/Dog/Cat)
Animal ape = new Animal("King Kong");
Dog    dog = new Dog("Scooby-Doo", "Mystery Inc.");
Cat    cat = new Cat("Garfield", "Lasagna");

Console.WriteLine("ape: " + ape);
Console.WriteLine("dog: " + dog);
Console.WriteLine("cat: " + cat);

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