using System.Linq.Expressions;

IEnumerable<int> numbers = Enumerable.Range(0, 1000);
Expression<Func<int,bool>> divisibleByThree = GetDivisorFilter(3);
Expression<Func<int,bool>> divisibleByFive = GetDivisorFilter(5);

Console.WriteLine(divisibleByThree.ToString());
Console.WriteLine(divisibleByFive.ToString());

IEnumerable<int> result = numbers
        .Where(divisibleByThree.Compile())
        .Where(divisibleByFive.Compile())
        .Take(10)
    ;

foreach (int number in result)
{
    Console.WriteLine(number);
}

Expression<Func<int, bool>> GetDivisorFilter(int divisor)
{
    Expression<Func<int, bool>> filter = x => (x % divisor) == 0;
    return filter;
}