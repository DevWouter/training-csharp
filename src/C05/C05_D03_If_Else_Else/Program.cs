

string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

string password = Ask("Please enter your password:"); 
string passwordConfirm = Ask("Please confirm your password:");

if (password == "")
{
    Console.WriteLine("You must enter a password!");
}else if (password != passwordConfirm)
{
    Console.WriteLine("Your password doesn't match");
    Console.WriteLine("Warning! This attempt has been logged!");
}
else
{
    Console.WriteLine("Your password has been changed");
}