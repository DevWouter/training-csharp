Customer client_unknown = new Customer();
Customer client_wouter = new Customer(1, "Wouter", "Lindenhof");
Customer client_rutger = new Customer(2, "Rutger Lindenhof");

// Customer client_illegal = new Customer("Sirus Lindenhof"); // This is illegal because the constructor is private

client_unknown.Print();
client_wouter.Print();
client_rutger.Print();

class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Print()
    {
        Console.WriteLine($"Id =  {Id} \t FirstName = \"{FirstName}\" \t LastName = \"{LastName}\"");
    }

    // This is a parameterless constructor
    public Customer()
    {
        Id = -1;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    // This is a constructor with parameters
    public Customer(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // This constructor calls another constructor
    public Customer(int id, string fullName) : this(fullName)
    {
        Id = id;
    }

    // This constructor is private, so it can only be called from within this class
    private Customer(string fullName)
    {
        string[] splitName = fullName.Split(' ');
        FirstName = splitName[0];
        LastName = splitName[1];
    }
}