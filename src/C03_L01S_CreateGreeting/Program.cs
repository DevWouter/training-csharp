// Lab 01 - Create greeting (solved)
//
// Requirements:
// 0. Only change code between the lines marked with "Only change code below
//    this line" and "Only change code above this line"
// 1. Ask the user for "What is your name?"
// 2. Ask the user for "How do you want to be greeted?"
// 3. Combine the greeting and the name into a single string, separated the greeting and the name with a comma.
//    Example: "Hello, world"
// 4. Write the combined string to the console
//
// Hints:
// 1. Use the `Ask` method to ask for the name and greeting
// 2. Stuck? Try writing the steps in plain English using comments.

string Ask(string question)
{
    Console.Write(question);
    string answer = Console.ReadLine();
    return answer;
}


string CreateGreeting()
{
    // ----->8------- Only change code below this line ----->8-------
    
    string name = Ask("What is your name? ");
    string greeting = Ask("How do you want to be greeted? ");
    string greetingAndName = greeting + ", " + name + "!";
    return greetingAndName;
    
    // <---->8------- Only change code above this line <----8-------
}


string greeting = CreateGreeting();
Console.WriteLine(greeting);