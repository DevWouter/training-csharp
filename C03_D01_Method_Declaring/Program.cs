﻿// NOTE: This application only declares a method, but does not invoke it.
//       Thus the application does not do anything.


// DECLARING A METHOD
// ┌ Return type (void is a special type and means that nothing is returned. Try describing "the void of space")
// │ ┌ Method name
// │ │              ┌ Opening parenthesis of the parameter list
// │ │              │┌ Closing parenthesis of the parameter list
void PrintHelloWorld()
{ // ← Start of the method body ( this character is called a curly brace or curly bracket)
    
    
    // Withing the method body we can put other statements.
    // These statements are executed when the method is invoked.
    string greeting = "Hello";
    string name = "World";
    string message = greeting + ", " + name + "!";
    Console.WriteLine(message);
    
    
}// ← End of the method body