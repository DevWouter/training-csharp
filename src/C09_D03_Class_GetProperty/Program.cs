// Explain get property

// ┌ Type of variable
// │     ┌ variable name (from here on called "client" to differentiate it from the type name)
// │     │      ┌ Assignment operator
// │     │      │ ┌ new keyword, indicates that we are creating a new "instance" of the type
// │     │      │ │   ┌ Name of the type we are creating.
Customer client = new Customer();
client.Id = 1;
client.FirstName = "Wouter";
client.LastName = "Lindenhof";


//                                       ┌ variable name
//                                       │      ┌ Field name of variable
Console.WriteLine("The FirstName is: " + client.FirstName);

//                                      ┌ variable name
//                                      │      ┌ Property name of variable
Console.WriteLine("The FullName is: " + client.FullName);


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
        // Get keyword (it actually creates a function called "string get_FullName()")
        get
        {
            // Hey, this looks like a function
            return $"{FirstName} {LastName}";
        }
    }
    
    // This is called a member function
    public void Greet()
    {
        Console.WriteLine($"Hi {FirstName} {LastName}");
    }
}