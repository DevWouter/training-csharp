string Ask(string question)
{
    Console.Write(question);
    string answer = Console.ReadLine();
    return answer;
}

// DECLARING A METHOD
// ┌ Return type (void)
// │   ┌ Method name
// │   │  ┌ Opening parenthesis of the parameter list
// │   │  │┌ type of first parameter (string)
// │   │  ││      ┌ name of first parameter (greeting)
// │   │  ││      │       ┌ Parameter separator
// │   │  ││      │       │ ┌ type of second parameter (string)
// │   │  ││      │       │ │      ┌ name of second parameter (name)
// │   │  ││      │       │ │      │   ┌ Closing parenthesis of the parameter list
void Greet(string greeting, string name)
{
    Console.WriteLine(greeting + ", " + name + "!");
    
    // ┌ The return keyword, notice that it is not followed by a value since the return type is void
    return;
    
    Console.WriteLine("This line will never be executed");
}

string answerToName = Ask("What is your name? ");
string answerToGreeting = Ask("How you do want to be greeted? ");

// INVOKING A METHOD
// ┌ The name of the method
// │ ┌ Opening parenthesis of the argument list
// │ │┌ Variable answerToGreeting is passed as the first argument
// │ ││               ┌ argument separator
// │ ││               │ ┌ Variable answerToName is passed as the second argument
// │ ││               │ │           ┌ Closing parenthesis of the argument list
// │ ││               │ │           │┌ Terminating the statement using a semicolon
Greet(answerToGreeting, answerToName);