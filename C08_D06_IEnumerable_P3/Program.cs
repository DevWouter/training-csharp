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
        // ┌ yield-keyword 
        // │  ┌ "yield return" to indicate that we want to return a value 
        // │  │      ┌ a value
        yield return i;
        i++;
        
        Console.Write("Press enter to continue or type 'q' to stop");
        var input = Console.ReadKey();
        Console.WriteLine();
        if (input.KeyChar == 'q')
        {
            // ┌ "yield break" to indicate that we want to stop the loop
            yield break;
        }
    }
}