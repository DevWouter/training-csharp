// Explain member functions

// ┌ Type of variable
// │     ┌ variable name
// │     │        ┌ Assignment operator
// │     │        │ ┌ new keyword, indicates that we are creating a new "instance" of the type
// │     │        │ │   ┌ Name of the type we are creating.
Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Wouter";
customer.LastName = "Lindenhof";

//                                       ┌ variable name
//                                       │      ┌ Field name of variable
Console.WriteLine("The FirstName is: " + customer.FirstName);

customer.Greet();

// ┌ Visibility keyword
// │   ┌ class keyword
// │   │     ┌ Name of the class
public class Customer
{
    // This is called a member field (or "field" for short).
    // ┌ Visibility keyword
    // │   ┌ Type of the field
    // │   │      ┌ Name of the field
    public int    Id;
    public string FirstName;
    public string LastName;

    // This is called a member function
    // ┌ Visibility keyword
    // │   ┌ Return type
    // │   │    ┌ Method name
    public void Greet()
    {
        //                                  ┌ This is a special keyword that refers to the current instance of the class
        Console.WriteLine($"Hi {FirstName} {this.LastName}");
    }
}