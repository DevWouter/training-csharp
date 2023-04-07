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
        if (Value == null) yield break;
        var current = this;
        while (current.Next != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    public Chain<T> GetLast()
    {
        if (Next == null)
            return this;
        else
            return Next.GetLast();
    }
}