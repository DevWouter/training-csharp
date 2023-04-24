IEnumerable<int> numbers = Enumerable.Range(0, 1000);
Func<int, bool> divisibleByThree = GetDivisorFilter(3);
Func<int, bool> divisibleByFive = GetDivisorFilter(5);

int result = numbers
        .Where(divisibleByThree)
        .Where(divisibleByFive)
        .Skip(1) // Because the first value is 0
        .Aggregate((x, y) => x * y)
    ;

Console.WriteLine($"Result: {result}");

Func<int, bool> GetDivisorFilter(int divisor)
{
    Func<int, bool> filter = x => (x % divisor) == 0;
    return filter;
}