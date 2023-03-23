ISpeaker? speaker = null;

while (speaker == null)
{
    Console.WriteLine("Please choose a speaker by pressing a number:");
    Console.WriteLine("1. Normal speaker");
    Console.WriteLine("2. Loud speaker");
    Console.WriteLine("3. Slow speaker");

    var key = Console.ReadKey();
    Console.WriteLine();
    if (key.KeyChar == '1') speaker = new NormalSpeaker();
    else if (key.KeyChar == '2') speaker = new LoudSpeaker();
    else if (key.KeyChar == '3') speaker = new SlowSpeaker();
    else Console.WriteLine("Invalid input");
}

var lastMessage = "";
while (lastMessage != "exit")
{
    Console.WriteLine("What do you want to say? (Type 'exit' to exit)");
    Console.Write("> ");
    lastMessage = Console.ReadLine();
    speaker.Speak(lastMessage);
}


// Interfaces can contain methods, properties, events, and indexers. The interface itself
// does not provide implementations for the members that it declares. The interface
// merely specifies the members that shall be supplied by classes or structs that implement
// the interface.
// 
// ┌ Visibility keyword
// │   ┌ Interface keyword
// │   │         ┌ Name of interface
public interface ISpeaker
{
    // It's members are public by default, so we don't need to specify it (we can if needed).
    // A member of an interface has no implementation, so we don't need to specify a body.
    void Speak(string message);
}

public class NormalSpeaker : ISpeaker
{
    public void Speak(string message)
    {
        Console.WriteLine(message);
    }
}

public class LoudSpeaker : ISpeaker
{
    public void Speak(string message)
    {
        Console.WriteLine(message.ToUpper());
    }
}

public class SlowSpeaker : ISpeaker
{
    public void Speak(string message)
    {
        // This is a slow speaker, so we add a delay after each character.
        foreach (char c in message)
        {
            Thread.Sleep(100);
            Console.Write(c);
        }

        Console.WriteLine();
    }
}