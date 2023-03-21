foreach (var number in GetAllNumbers())
{
    Console.WriteLine(number);
}




// ┌ An IEnumerable of type int
IEnumerable<int> GetAllNumbers()
{
    int i = 0;
    while (true)
    {
        // ┌ yield-keyword that temporarily
        // │  ┌ returns
        // │  │      ┌ a value
        yield return i;
        i++;
    }
}
