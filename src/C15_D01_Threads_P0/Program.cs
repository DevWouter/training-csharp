var start = DateTime.Now;

Console.WriteLine("Result:");
foreach (var i in Enumerable.Range(0, 10))
{
    Console.WriteLine("- " + Square(i));
}

var end = DateTime.Now;
var difference = end - start;
Console.WriteLine("Time taken: {0}", difference);

int Square(int x)
{
    Thread.Sleep(1000);
    return x * x;
}
