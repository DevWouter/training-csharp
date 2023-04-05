// The old way of doing things:
// ┌ Type "Console" (also a static class)
// │   ┌ The "." indicates that we are invoking a method on the object
// │   │ ┌ Method "WriteLine"
// │   │ │       ┌ Opening parenthesis indicates that we are invoking the method and passing arguments
// │   │ │       │ ┌ Argument (a string literal)
// │   │ │       │ │            ┌ End of the argument list
// │   │ │       │ │            │┌ Terminating the statement using a semicolon
Console.WriteLine("Hello, world");


// Using a variable:
// ┌ Variable type is "string" (a built-in type)
// │   ┌ variable name (so that we can refer to the value later)
// │   │       ┌ Assign operator (stores the value in a variable)
// │   │       │ ┌ Start of the string literal
// │   │       │ │                      ┌ End of the string literal 
// │   │       │ │                      │┌ Terminating the statement using a semicolon
string message = "Good morning, Universe";


// ┌ Type "Console" (also a static class)
// │   ┌ The "." indicates that we are invoking a method on the object
// │   │ ┌ Method "WriteLine"
// │   │ │       ┌ Opening parenthesis indicates that we are invoking the method and passing arguments
// │   │ │       │ ┌ Argument (a variable)
// │   │ │       │ │     ┌ Closing parenthesis indicates the end of the argument list
// │   │ │       │ │     │┌ Terminating the statement using a semicolon
Console.WriteLine(message);