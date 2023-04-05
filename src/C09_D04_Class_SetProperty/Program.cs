// Explain set property

Customer client = new Customer();
client.Id = 1;
client.FullName = "Wouter Lindenhof";

Console.WriteLine("The Firstname is: " + client.FirstName);
Console.WriteLine("The LastName is: " + client.LastName);


public class Customer
{
    // This is called a member field (or "field" for short).
    public int Id;
    public string FirstName;
    public string LastName;

    // This is called a member property (or "property" for short).
    // ┌ Visibility keyword
    // │   ┌ Type of the property
    // │   │      ┌ Name of the property
    public string FullName
    {
        // Set keyword (it actually creates a function called "void set_FullName(string value)")
        set
        {
            //               ┌ value is a special keyword that contains the value that was passed to the property
            string[] parts = value.Split(' ');
            FirstName = parts[0];
            LastName = parts[1];
        }
        
        // Due to `get` is missing we also call this a "set-only property" or a "write-only property"
        // When `set` is missing we call this a "get-only property" or a "read-only property"
    }
}