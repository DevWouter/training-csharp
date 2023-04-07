var nl2En = new Translator<string, string>();
nl2En.Add("Hond", "Dog");
nl2En.Add("Kat", "Cat");
nl2En.Add("Muis", "Mouse");

Console.WriteLine("'Hond' in english is " + nl2En.Translate("Hond"));

var dev2En = new Translator<TranslateStrings, string>();
dev2En.Add(TranslateStrings.HelloWorld, "Hello World!");
dev2En.Add(TranslateStrings.GoodbyeWorld, "Goodbye World!");

Console.WriteLine("TranslateStrings.HelloWorld in english is " + dev2En.Translate(TranslateStrings.HelloWorld));

public enum TranslateStrings
{
    HelloWorld,
    GoodbyeWorld,
}

public class Translator<TKey, TValue>
{
    public record Entry(TKey Key, TValue Value);

    private readonly Chain<Entry> _chain = new Chain<Entry>();

    public void Add(TKey key, TValue value)
    {
        _chain.Add(new Entry(key, value));
    }

    public TValue Translate(TKey key)
    {
        foreach (var entry in _chain.GetValues())
        {
            if (entry.Key.Equals(key))
                return entry.Value;
        }

        throw new Exception("Key not found");
    }
}