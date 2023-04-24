IEnumerable<int> numbers = Enumerable.Range(0, 1000);
Func<int,bool> divisibleByThree = GetDivisorFilter();
Func<int,bool> divisibleByFive = x => (x % 5) == 0;

IEnumerable<int> result = numbers
        .Where(divisibleByThree)
        .Where(divisibleByFive)
        .Take(10)
    ;

foreach (int number in result)
{
    Console.WriteLine(number);
}

Func<int, bool> GetDivisorFilter()
{
    Func<int, bool> func = x => (x % 3) == 0;
    return func;
}

