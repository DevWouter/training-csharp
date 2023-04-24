FootballTeam team = new FootballTeam();
team.Name = "Camas IT";
team.Players.Add(new Keeper() { Name = "Wouter", IsPenaltyKiller = false });
team.Players.Add(new FootballPlayer() { Name = "Rutger" });
team.Players.Add(new FootballPlayer() { Name = "Joke" });
team.Players.Add(new FootballPlayer() { Name = "Jan" });

Console.WriteLine("Team: " + team);

public class FootballPlayer
{
    public string Name { get; set; }

    // Override the default ToString() method, but we use a shorter syntax
    //                                ┌ Expression body syntax
    public override string ToString() => $"Player: {Name}";
}

// ┌ Visibility
// │   ┌ class (reference type)
// │   │     ┌ Name of type
// │   │     │       ┌ inherit
// │   │     │       │ ┌ Base class
public class Keeper : FootballPlayer
{
    public bool IsPenaltyKiller { get; set; }

    public override string ToString() => $"Keeper: {Name} (PenaltyKiller: {IsPenaltyKiller})";
}

public class FootballTeam
{
    public string Name { get; set; }

    public List<FootballPlayer> Players { get; set; } = new();
    public override string ToString()
    {
        return "Team " + Name;
    }
}