Employee wouter = new Employee("Wouter");
Manager rutger = new Manager("Rutger", "IT");
Console.WriteLine("[Wouter] " + wouter);
Console.WriteLine("[Rutger] " + rutger);

public class Employee
{
    public string Name { get; private set; }

    public Employee(string name)
    {
        Name = name.ToUpper();
    }
    
    public override string ToString() => $"Employee: {Name}";
}

public class Manager : Employee
{
    public string Department { get; set; }

    public override string ToString() => $"{Department} Manager: {Name}";

    public Manager(string name, string department) : base(name)
    {
        // We still need to set the member property "Department"
        Department = department;
    }
}