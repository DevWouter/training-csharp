IEnumerable<int> numbers = Enumerable.Range(0, 1000);

List<Func<int, bool>> filters = new List<Func<int, bool>>();

string lastValue = string.Empty;
do
{
    Console.WriteLine("By which number should the value be divisible?");
    lastValue = Console.ReadLine();
    if (int.TryParse(lastValue, out int number))
    {
        filters.Add(GetDivisorFilter(number));
    }
} while (lastValue != string.Empty);

IEnumerable<int> result = numbers;
foreach (var filter in filters)
{
    result = result.Where(filter);
}

foreach (int number in result)
{
    Console.WriteLine(number);
}

Func<int, bool> GetDivisorFilter(int divisor)
{
    Func<int, bool> filter = x => (x % divisor) == 0;
    return filter;
}