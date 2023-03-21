// Explain pass by reference

Customer client = new Customer();
client.Id = 1;
client.FirstName = "???";
client.LastName = "???";

UpdateFirstName(ref client, "Wouter");
UpdateLastName(ref client, "Lindenhof");

Console.WriteLine("The Firstname is: " + client.FirstName);
Console.WriteLine("The LastName is: " + client.LastName);

//                   ┌ ref keyword (so that the value is passed by reference)
void UpdateFirstName(ref Customer buyer, string firstName)
{
    buyer.FirstName = firstName;
}

//                   ┌ ref keyword (so that the value is passed by reference)
void UpdateLastName(ref Customer buyer, string lastName)
{
    buyer.LastName = lastName;
}

public struct Customer
{
    public int Id; // A field
    public string FirstName { get; set; } // A property
    public string LastName { get; set; }
}