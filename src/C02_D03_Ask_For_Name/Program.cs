// Writes a message to the console, note we use `Write` instead of `WriteLine`
Console.Write("Please enter your name: ");

// Reads a line (text terminated by a newline) from the console and stores it in a variable
string name = Console.ReadLine();

// Combines the string literal "Hello, " with the value of the variable `name` and stores it in a variable
string message = "Hello, " + name;

// Writes the value of the variable `message` to the console
Console.WriteLine(message);