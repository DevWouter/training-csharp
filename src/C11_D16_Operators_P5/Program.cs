// Conversion operators
using System.Globalization;

Money euro_100 = new Money("euro", 100.00m);
Money euro_200 = "euro 200.00"; // Implicit conversion

Console.WriteLine(euro_100);
Console.WriteLine(euro_200);


class Money
{
    public string Symbol { get; set; }
    public decimal Value { get; set; }
    
    public Money(string symbol, decimal value)
    {
        Symbol = symbol;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value} in {Symbol}";
    }

    public static implicit operator Money(string value)
    {
        var split = value.Split(' ');
        return new Money(split[0], decimal.Parse(split[1], CultureInfo.InvariantCulture));
    }
}