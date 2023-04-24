IEnumerable<int> numbers = Enumerable.Range(0, 1000);
IEnumerable<int> result = numbers.Where(x => (x % 3) == 0);

foreach (int number in result)
{
    Console.WriteLine(number);
}