// Explain static methods and static properties

Customer client1 = new Customer("Carmen");
Customer client2 = new Customer("Julian");

Customer.PrintAllCustomers();

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // ┌ Visibility modifier
    // │   ┌ Static keyword
    // │   │      ┌ Type
    // │   │      │              ┌ Name
    public static int            CustomerCreated { get; set; }
    public static List<Customer> AllCustomers { get; set; } = new List<Customer>();

    // This method will be called when the class is loaded, it only executes once at most. Note that it has no visibility modifier.
    // ┌ Static keyword
    // │   ┌ Constructor
    static Customer()
    {
        Console.WriteLine("Static constructor called");
        CustomerCreated = 1000;
    }
    
    // An instance constructor
    public Customer(string name)
    {
        Console.WriteLine("Instance Constructor called");
        Name = name;
        
        // We can access static properties and methods from instance methods
        Id = ++CustomerCreated;
        
        // And with `this` we can access the current instance (the object that is currently being created)
        AllCustomers.Add(this);
    }

    public static void PrintAllCustomers()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("CustomerCreated: " + CustomerCreated);
        Console.WriteLine("All customers:");
        foreach (var customer in AllCustomers)
        {
            Console.WriteLine(customer);
        }
    }
    
    public override string ToString()
    {
        return $"- Id {Id}: {Name}";
    }
}