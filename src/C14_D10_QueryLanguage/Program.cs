IEnumerable<int> numbers = Enumerable.Range(0, 1000);
Func<int, bool> divisibleByThree = GetDivisorFilter(3);
Func<int, bool> divisibleByFive = GetDivisorFilter(5);

var query = from n in numbers
    where divisibleByFive(n)
    where divisibleByThree(n)
    select n;

int result = query
        .Skip(1) // Because the first value is 0
        .Take(10)
        .Aggregate((x, y) => x * y)
    ;

Console.WriteLine("Result " + result);

Func<int, bool> GetDivisorFilter(int divisor)
{
    Func<int, bool> filter = x => (x % divisor) == 0;
    return filter;
}