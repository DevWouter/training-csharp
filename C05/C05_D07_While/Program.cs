
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

string password = AskPassword("Please enter your password:"); 
string passwordConfirm = AskPassword("Please confirm your password:");

if (password != passwordConfirm)
{
    Console.WriteLine("Your password doesn't match");
    Console.WriteLine("Warning! This attempt has been logged!");
}
else
{
    Console.WriteLine("Your password has been changed");
}