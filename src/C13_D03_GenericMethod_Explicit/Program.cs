﻿int intValue = 1234;
double doubleValue = 1234.567d;
float floatValue = 987.6543f;
var stringValue = "Hello World!";

Output.Write<double>(intValue);
Output.Write<double>(floatValue);
Output.Write<double>(doubleValue);
Output.Write(stringValue);

public class Output
{
    public static void Write<T>(T value)
    {
        Console.WriteLine($"Write({typeof(T).Name} value), \tvalue = {value}");
    }

    public static void Write(string value)
    {
        Console.WriteLine($"Write(string value), \tvalue = {value}");
    }
}