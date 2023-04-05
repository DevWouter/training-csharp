// Explain that structs are value types
// We only changed the class keyword to struct

Customer client = new Customer();
client.Id = 1;
client.FirstName = "???";
client.LastName = "???";

UpdateFirstName(client, "Wouter");
UpdateLastName(client, "Lindenhof");

Console.WriteLine("The Firstname is: " + client.FirstName);
Console.WriteLine("The LastName is: " + client.LastName);

void UpdateFirstName(Customer buyer, string firstName)
{
    buyer.FirstName = firstName;
}

void UpdateLastName(Customer buyer, string lastName)
{
    buyer.LastName = lastName;
}

//     ┌ Struct keyword (before it was a class)
public struct Customer
{
    public int Id;
    public string FirstName;
    public string LastName;
}