// Lines starting with "//" are comments and are ignored by the compiler.
// The compiler only cares about the code that is not commented out.

/* A multi-line comment can also be used.
   This is useful for large comments that span multiple lines.
   That way you don't have to write "//" at the beginning of each line.
   You can also put the multi-line halfway through a line.
*/

// ┌ Type "Console" (a type)
// │   ┌ The "." indicates that we access a method on the type
// │   │ ┌ Method "WriteLine"
// │   │ │       ┌ Opening parenthesis indicates that we are invoking the method and passing arguments
// │   │ │       │ ┌ Argument (a string literal, which is a string enclosed in double quotes)
// │   │ │       │ │            ┌ Closing parenthesis indicates the end of the argument list
// │   │ │       │ │            │┌ Terminating the statement using a semicolon
Console.WriteLine("Hello, World!");