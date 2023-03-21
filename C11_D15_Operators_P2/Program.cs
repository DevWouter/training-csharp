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
// account3 = 100 + account3;   // Not allowed, requires left to be a integer and right to be a GameAccount
// account3 -= 100;             // Not allowed, different operator

Console.WriteLine("After providing points");
Console.WriteLine("- " + account1);
Console.WriteLine("- " + account2);
Console.WriteLine("- " + account3); // Unchanged


class GameAccount
{
    public string Name { get; set; }
    public int Points { get; set; }

    public GameAccount(string name)
    {
        Name = name;
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

    public override string ToString()
    {
        return $"{Name} has {Points} points";
    }

    public static GameAccount operator +(GameAccount left, int right)
    {
        left.Points += right;
        return left;
    }
}