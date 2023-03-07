// Lines starting with "//" are comments and are ignored by the compiler.
// The compiler only cares about the code that is not commented out.

/* A multi-line comment can also be used.
   This is useful for large comments that span multiple lines.
   That way you don't have to write "//" at the beginning of each line.
   You can also put the multi-line halfway through a line.
*/

// ┌ Namespace-keyword
// │     ┌ Name of the namespace
namespace HelloWorld01_Classic;

// ┌ Visibility
// │     ┌ static keyword (indicates that the class is static and cannot be instantiated)
// │     │     ┌ class-keyword (indicates that this is a class)
// │     │     │     ┌ Name of the class (often matches the name of the file)
public static class Program
{
    // The entry point of our application.
    // The name "Main" is special, since it indicates the entry point of the application.
    //
    // ┌ Visibility
    // │     ┌ static keyword (required since an application only has one entry point)
    // │     │     ┌ Return type
    // │     │     │     ┌ Method name
    public static void Main()
    {   // ← Start of the method body
        
        // The one and only statement in our application.
        // Here we invoke the static method `WriteLine` on the static class `Console`.
        //
        // ┌ Type "Console" (also a static class)
        // │   ┌ The "." indicates that we are operating a method on the object
        // │   │ ┌ Method "WriteLine"
        // │   │ │       ┌ Opening parenthesis indicates that we are invoking the method and passing arguments
        // │   │ │       │ ┌ Argument (a string literal, which is a string enclosed in double quotes)
        // │   │ │       │ │            ┌ Closing parenthesis indicates the end of the argument list
        // │   │ │       │ │            │┌ Terminating the statement using a semicolon
        Console.WriteLine("Hello, world");
    } // ← End of the method body
} // ← End of the class body