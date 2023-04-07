Chain<int> numbersChain = new Chain<int>();
numbersChain.Add(1);
numbersChain.Add(2);
numbersChain.Add(3);


foreach (int value in numbersChain.GetValues())
{
    Console.WriteLine(value);
}

Chain<string> stringChain = new Chain<string>();
stringChain.Add("Hello");
stringChain.Add("World");
stringChain.Add("!");

foreach (var value in stringChain.GetValues())
{
    Console.WriteLine(value);
}


public class Chain<T>
{
    private T Value { get; set; }
    private Chain<T>? Next { get; set; }

    public void Add(T value)
    {
        GetLast().Next = new Chain<T> { Value = value };
    }

    public IEnumerable<T> GetValues()
    {
        yield return Value;
        if (Next != null)
            foreach (var value in Next.GetValues())
                yield return value;
    }

    public Chain<T> GetLast()
    {
        if (Next == null)
            return this;
        else
            return Next.GetLast();
    }
}