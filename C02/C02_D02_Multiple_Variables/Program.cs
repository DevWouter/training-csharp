// We can declare multiple variables, but each variable must have a unique name.
string greeting = "Hello";
string name = "world";


// 🆕 Combines the string literal "Hello, " with the value of the variable `name` and stores it in a variable
// ┌ Variable type
// │   ┌ Variable name 
// │   │       ┌ Assign
// │   │       │ ┌ First variable (a string variable)
// │   │       │ │        ┌ Add operator 
// │   │       │ │        │ ┌ String literal
// │   │       │ │        │ │    ┌ Add operator
// │   │       │ │        │ │    │    ┌ Second variable (a string variable) 
// │   │       │ │        │ │    │    │┌ Terminator
string message = greeting + ", " + name;


// Writes the value of the variable `message` to the console
Console.WriteLine(message);