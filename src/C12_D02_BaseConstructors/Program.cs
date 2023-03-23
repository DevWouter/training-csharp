Employee wouter = new Employee("Wouter");
Manager rutger = new Manager("Rutger", "IT");

Console.WriteLine("[Wouter] " + wouter);
Console.WriteLine("[Rutger] " + rutger);

public class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    // Override the default ToString() method, but we use a shorter syntax
    //                                ┌ Expression body syntax
    public override string ToString() => $"Employee: {Name}";
}

// ┌ Visibility
// │   ┌ class (reference type)
// │   │     ┌ Name of type
// │   │     │       ┌ inherit
// │   │     │       │ ┌ Base class
public class Manager : Employee
{
    public string Department { get; set; }

    public override string ToString() => $"{Department} Manager: {Name}";

    // ┌ Visibility
    // │   ┌ Constructor
    // │   │       ┌ Parameters
    // │   │       │                                 ┌ Call base constructor (base is a keyword)
    public Manager(string name, string department) : base(name)
    {
        // We still need to set the member property "Department"
        Department = department;
    }
}