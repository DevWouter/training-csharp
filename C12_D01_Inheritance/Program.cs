Employee wouter = new Employee();
wouter.Name = "Wouter";

Manager rutger = new Manager();
rutger.Name = "Rutger";
rutger.Department = "IT";

Console.WriteLine("[Wouter] " + wouter);
Console.WriteLine("[Rutger] " + rutger);

public class Employee
{
    public string Name { get; set; }

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
}