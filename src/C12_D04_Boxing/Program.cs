// WARNING: This application has no output
// ---------------------------------------

// Within the world of dotnet, there are two types of boxing:
// 1. Boxing a value type into an object
// 2. Boxing a reference type into an object
//
// This is a special type of casting, which was common in the early version of .NET Framework before generics were introduced.
// Don't worry about generics, we will cover them in a later chapter.
//
// Basically in dotnet every type is a super class of object. So when you create a variable of type int, it is actually a variable of type object.
// And if we create our own class, even without inheriting from object, it will still be a super class of object.

object boxedInt = 1234;
int unboxedInt = (int)boxedInt;

object boxedString = "Hello World!";
string unboxedString = (string)boxedString;

// The same goes for reference types.
object boxedAnimal = new Animal();
Animal unboxedAnimal = (Animal)boxedAnimal;

// And this is problematic, because we can cast any object to any type.
boxedInt    = new Human();

// But the cool thing is, that we can always store any variable in a list of objects
List<object> objects = new List<object>();
objects.Add(boxedInt);      // Variable type: Object, actual type: Human
objects.Add(unboxedAnimal); // Variable type: Animal, actual type: Animal
objects.Add(boxedAnimal);   // Variable type: Object, actual type: Animal

// The null literal is of a special "null-type", which modern dotnet tries to move away from.
// So the next line might fail in future versions of dotnet (or if you turn on a specific compiler flag).
objects.Add(null);

public class Animal
{
    // ...
}

public class Human
{
    // ...
}