var start = DateTime.Now;

List<Task> tasks = new();
Console.WriteLine("Result:");
foreach (var i in Enumerable.Range(0, 1000))
{
    // Task.Run() starts a new thread and returns a Task object.
    var task = Task.Run(() => Console.WriteLine($"- {i} * {i} = " + Square(i)));
    tasks.Add(task);
}

Task.WaitAll(tasks.ToArray());

var end = DateTime.Now;
var difference = end - start;
Console.WriteLine("Time taken: {0}", difference);

int Square(int x)
{
    Thread.Sleep(1000);
    return x * x;
}