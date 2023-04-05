// Explain  

var account1 = new GameAccount("Carmen");
var account2 = new GameAccount("Julian");
var account3 = new GameAccount("Bianca");


Console.WriteLine("Compare operators");
Console.WriteLine("account1 == \"Carmen\": " + (account1 == "Carmen"));
Console.WriteLine("account1 == \"Julian\": " + (account1 == "Julian"));
Console.WriteLine("account2 != \"Carmen\": " + (account2 != "Carmen"));
Console.WriteLine("account2 != \"Julian\": " + (account2 != "Julian"));

Console.WriteLine("Initial status");
Console.WriteLine("- " + account1);
Console.WriteLine("- " + account2);
Console.WriteLine("- " + account3);

// GameAccount.operator+(GameAccount, int) which returns a GameAccount
account1 += 300;
account2 = account2 + 200;
// account3 = 100 + account3;   // allowed, but returns an int which cannot be assigned to a GameAccount
// account3 -= 100;             // Not allowed, different operator

Console.WriteLine("Summing up all accounts");
int sum1 = account1 + account2; // int GameAccount.operator+(GameAccount left, GameAccount right)
int sum2 = sum1 + account3;     // int GameAccount.operator+(int left,         GameAccount right)
Console.WriteLine("Total points of all accounts: " + sum2);


class GameAccount
{
    public string Name { get; set; }
    public int Points { get; set; }

    public GameAccount(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name} has {Points} points";
    }

    // Add operator overloading so that we can compare it to a string
    public static bool operator ==(GameAccount account, string name)
    {
        return account.Name == name;
    }

    // When providing a equals operator, you should also provide a not-equals operator
    public static bool operator !=(GameAccount account, string name)
    {
        // And we can do that by just inverting the result of the equals operator
        return !(account == name);
    }

    public static GameAccount operator +(GameAccount account, int pointIncrease)
    {
        account.Points += pointIncrease;
        return account;
    }

    public static int operator +(GameAccount a, GameAccount b)
    {
        return a.Points + b.Points;
    }

    public static int operator +(int a, GameAccount b)
    {
        return a + b.Points;
    }
}