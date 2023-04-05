// DECLARING A METHOD
// NOTE: We talk about declaring "parameters" when we declare a method. The calling function provides "arguments".
// ┌ Return type (void is a special type and means that nothing is returned. Try describing "the void of space")
// │ ┌ Method name
// │ │       ┌ Opening parenthesis of the parameter list
// │ │       │┌ parameter type (a string)
// │ │       ││      ┌ parameter name
// │ │       ││      │   ┌ Closing parenthesis of the parameter list
void SayHello(string name)
{ // ← Start of the method body ( this character is called a curly brace or curly bracket)
    
    
    // Withing the method body we can put other statements.
    // These statements are executed when the method is invoked.
    string greeting = "Hello";
    // NOTE: That the variable `name` is now a parameter of the method. 
    string message = greeting + ", " + name + "!";
    Console.WriteLine(message);
    
    
}// ← End of the method body


// INVOKING A METHOD
// NOTE: We talk about passing "arguments" when we invoke a method. The receiving function sees them as "parameters".
// ┌ The name of the method
// │    ┌ Opening parenthesis of the argument list
// │    │┌ String literal is passed as the first argument
// │    ││     ┌ Closing parenthesis of the argument list
// │    ││     │┌ Terminating the statement using a semicolon
SayHello("world");


// Asking the user for their name.
Console.WriteLine("What is your name? ");

// NOTE: That we declare a variable here with the same name as the parameter of the method.
//       Although the name is the same, the variable is declared in a different scope.
string name = Console.ReadLine();

// Invoke the method with the variable as the argument.
SayHello(name);