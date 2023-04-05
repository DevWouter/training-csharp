string AskPassword(string question)
{
    string answer = "";

    // `answer == ""` is an expression that evaluates to a boolean value.
    // As long as that expression is `true`, the loop will continue.
    while (answer == "")
    {
        Console.Write(question + " ");
        answer = Console.ReadLine();
    }

    return answer;
}

bool passwordsAreDifferent;

// The `do` keyword is used to start a loop, at the end of the loop it has a while condition.
// This is called a do-while loop.
// The loop will always run at least once, and then it will check the while condition.
// If the while condition is true, the loop will run again.
// NOTE: That `passwordsAreDifferent` is declared outside the loop, so it can be used inside the loop.
//
// HINT: Most developers prefer to use a while loop instead of a do-while loop. So you will rarely see a do-while loop.
do
{
    string password = AskPassword("Please enter your password:");
    string passwordConfirm = AskPassword("Please confirm your password:");

    passwordsAreDifferent = password != passwordConfirm;

    if (passwordsAreDifferent)
    {
        Console.WriteLine("Your password doesn't match, please try again");
    }
    
} while(passwordsAreDifferent);