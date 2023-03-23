foreach (var number in GetAllNumbers())
{
    Console.WriteLine(number);

    // Stop counting at 100
    if (number == 100) break;
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



foreach (var weekday in GetWorkdays())
{
    Console.WriteLine("-------");
    Console.WriteLine(weekday);
}


IEnumerable<string> GetWorkdays()
{
    yield return "Monday";
    yield return "Tuesday";
    yield return "Wednesday";
    yield return "Thursday";
    yield return "Friday";
}