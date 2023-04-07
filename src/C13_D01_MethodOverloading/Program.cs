int intValue = 1234;
double doubleValue = 1234.567d;
float floatValue = 987.6543f;
var stringValue = "Hello World!";

Output.Write(intValue);
Output.Write(doubleValue);
Output.Write(floatValue);
Output.Write(stringValue);

public class Output
{
    public static void Write(int value)
    {
        Console.WriteLine("Write(int value),     value = " + value);
    }

    public static void Write(double value)
    {
        Console.WriteLine("Write(decimal value), value = " + value);
    }

    public static void Write(string value)
    {
        Console.WriteLine("Write(string value),  value = " + value);
    }
}