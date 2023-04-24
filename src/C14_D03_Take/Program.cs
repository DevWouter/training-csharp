IEnumerable<int> numbers = Enumerable.Range(0, 1000);
IEnumerable<int> limitedNumbers = numbers.Take(10);

foreach (int number in limitedNumbers)
{
    Console.WriteLine(number);
}