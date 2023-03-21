// Explain Auto-property (Sometimes called by "Property with backing field")

Customer client = new Customer();
client.Id = 1;
client.FullName = "Wouter Lindenhof";

// customer._firstName = "Wouter"; // Is not allowed because _firstName is private

Console.WriteLine("The Firstname is: " + client.FirstName);
Console.WriteLine("The LastName is: " + client.LastName);


public class Customer
{
    // A public field that is initialized with -1
    // ┌ Visibility keyword
    // │   ┌ Type of the field
    // │   │   ┌ Name of the field
    // │   │   │  ┌ Assignment operator
    // │   │   │  │ ┌ Initial value
    public int Id = -1;
    
    // A private field that is initialized with an empty string
    // ┌ Visibility keyword
    // │    ┌ Type of the field
    // │    │      ┌ Name of the field
    // │    │      │          ┌ Assignment operator
    // │    │      │          │ ┌ Initial value
    private string _firstName = string.Empty;

    // A public property
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    // Auto property (exactly the same as above but it requires less typing)  
    public string LastName { get; set; }

    // Another public property
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
        
        set
        {
            string[] parts = value.Split(' ');
            FirstName = parts[0];
            LastName = parts[1];
        }
    }
}