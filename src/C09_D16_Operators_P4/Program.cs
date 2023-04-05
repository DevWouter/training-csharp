StoreAccount client1 = new StoreAccount(1, "Carmen");
client1.Credits = 100;

Console.WriteLine("Implicit conversion");
string implicitClientString = client1;
int implicitClientInt = client1;
decimal implicitClientDecimal = client1;

Console.WriteLine($"clientString:  {implicitClientString}");
Console.WriteLine($"clientInt:     {implicitClientInt}");
Console.WriteLine($"clientDecimal: {implicitClientDecimal}");


Console.WriteLine("Explicit conversion");
string explicitClientString = (string)client1;
int explicitClientInt = (int)client1;
decimal explicitClientDecimal = (decimal)client1;

Console.WriteLine($"clientString:  {explicitClientString}");
Console.WriteLine($"clientInt:     {explicitClientInt}");
Console.WriteLine($"clientDecimal: {explicitClientDecimal}");


class StoreAccount
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Credits { get; set; }

    public StoreAccount(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Id {Id}: {Name}, {Credits} credits";
    }
    
    // Cast operator from StoreAccount to int
    public static implicit operator int(StoreAccount account)
    {
        return account.Id;
    }
    
    public static implicit operator string(StoreAccount account)
    {
        return account.Name;
    }
    
    public static explicit operator decimal(StoreAccount account)
    {
        return account.Credits;
    }

}