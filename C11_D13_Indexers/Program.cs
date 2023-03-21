// Explain indexers
// - We already used indexers when we used arrays
// - 

var clientWouter = new Customer(14, "Wouter Lindenhof");
var clientJoke = new Customer(23, "Joke Lindenhof");
var clientRutger = new Customer(49, "Rutger Lindenhof");
var clientJan = new Customer(40, "Jan Lindenhof");

Store shop = new Store();
shop.Add(clientWouter);
shop.Add(clientJoke);
shop.Add(clientRutger);
shop.Add(clientJan);

shop.PrintKnownClients();

Console.WriteLine("Press enter to continue...");
Console.ReadLine();

shop[0].AllowEntry = false;
shop["Jan Lindenhof"].AllowEntry = false;

shop.PrintKnownClients();


class Customer
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public bool AllowEntry { get; set; } = true;

    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }

    public Customer(int id, string name)
    {
        Id = id;
        FirstName = name.Split(' ')[0];
        LastName = name.Split(' ')[1];
    }
}

class Store
{
    public int Id { get; set; }
    public string Name { get; set; }

    private List<Customer> _knownClients = new List<Customer>();

    public void Add(Customer newClient)
    {
        _knownClients.Add(newClient);
    }

    // Use indexer to get client by id
    public Customer this[int clientIndex]
    {
        get { return _knownClients[clientIndex]; }
    }

    // Use indexer to get client by name
    public Customer this[string clientName]
    {
        get
        {
            for (var i = 0; i < _knownClients.Count; ++i)
            {
                var client = _knownClients[i];
                if (client.FullName == clientName) return client;
            }

            throw new Exception($"Client {clientName} not found");
        }
    }

    public void PrintKnownClients()
    {
        Console.WriteLine($"Store {Name} (Id: {Id}) allows the following clients:");
        foreach (var client in _knownClients)
        {
            if (client.AllowEntry)
            {
                Console.WriteLine($"- {client.FirstName} {client.LastName} (Id: {client.Id})");
            }
        }


        Console.WriteLine($"Store {Name} (Id: {Id}) denies the following clients:");
        foreach (var client in _knownClients)
        {
            if (client.AllowEntry) continue;
            Console.WriteLine($"- {client.FirstName} {client.LastName} (Id: {client.Id})");
        }

        Console.WriteLine($"Total clients: {_knownClients.Count}");
    }
}