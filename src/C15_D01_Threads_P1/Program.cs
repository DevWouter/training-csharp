var start = DateTime.Now;

List<Thread> threads = new();

Console.WriteLine("Result:");
foreach (var i in Enumerable.Range(0, 10))
{
    var thread = new Thread(
        () => Console.WriteLine($"- {i} * {i} = " + Square(i))
        );
    threads.Add(thread);
    thread.Start();
}

// Wait for all threads to finish.
foreach (var thread in threads)
{
    thread.Join();
}

var end = DateTime.Now;
var difference = end - start;
Console.WriteLine("Time taken: {0}", difference);

int Square(int x)
{
    Thread.Sleep(1000);
    return x * x;
}