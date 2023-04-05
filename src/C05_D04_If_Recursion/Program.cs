

string AskPassword(string question)
{
    Console.Write(question + " ");
    string answer = Console.ReadLine();
    
    if (answer != "")
    {
        return answer;
    }
    
    // This part is only reached if the answer is empty
    // NOTE: That we are calling the current question again, this is called recursion.
    Console.WriteLine("You must enter a password!");
    return AskPassword(question);
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