// DECLARING A METHOD
// NOTE: We talk about declaring "parameters" when we declare a method. The calling function provides "arguments".
// ┌ Return type (string)
// │   ┌ Method name
// │   │  ┌ Opening parenthesis of the parameter list
// │   │  │┌ parameter type (a string)
// │   │  ││      ┌ parameter name
// │   │  ││      │       ┌ Closing parenthesis of the parameter list
string Ask(string question)
{ // ← Start of the method body ( this character is called a curly brace or curly bracket)
    
    
    Console.Write(question);
    string answer = Console.ReadLine();
    
    // ┌ return keyword
    // │   ┌ The value that needs to be returned
    // │   │     ┌ Terminating the statement using a semicolon
    return answer;
    
    // NOTE: That once the return statement is executed, the method will exit.
    //       Thus the following line will never be executed.
    Console.WriteLine("This line will never be executed");
    
}// ← End of the method body


// ┌ Declaring the type of variable (string)
// │   ┌ Declaring the name of the variable (name)
// │   │    ┌ Assigning "the value on the right" to "the variable on the left" of the equals sign
// │   │    │ ┌ The name of the method
// │   │    │ │  ┌ Opening parenthesis of the argument list
// │   │    │ │  │┌ String literal is passed as the first argument
// │   │    │ │  ││                   ┌ Closing parenthesis of the argument list
// │   │    │ │  ││                   │┌ Terminating the statement using a semicolon
string name = Ask("What is your name? ");
string greeting = Ask("How do want to be greeted? ");

Console.WriteLine(greeting + ", " + name + "!");