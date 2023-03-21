// Explain constructor
Customer client = new Customer("Wouter", "Lindenhof");

Console.WriteLine("The Firstname is: " + client.FirstName);
Console.WriteLine("The LastName is: " + client.LastName);


public class Customer
{
    // Note that the constructor has no return type, this is because it returns an instance of the class
    // ┌ Visibility keyword
    // │   ┌ Type name
    // │   │            ┌ Parameters
    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    
    public int Id { get; set; } = -1;                     // <-- Auto-implemented properties can also be initialized
    public string FirstName { get; set; } = string.Empty; // <-- Useless initialization since the constructor will overwrite it
    public string LastName { get; set; }                  // <-- No initialization, but the constructor will set it  

    // Non-auto-implemented property
    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }
}