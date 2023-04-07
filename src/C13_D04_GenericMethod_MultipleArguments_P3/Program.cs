int intA = 2;
int intB = 3;

float floatC = 4.0f;
float floatD = 5.0f;

Swapper.Swap(ref intA, ref intB);
Swapper.Swap(ref floatC, ref floatD);

// This didn't work before but now it does 
Swapper.Swap(ref intA, ref floatD);

// We can now swap both directions.
Swapper.Swap<float, int>(ref floatC, ref intB);

void PrintAllVariables(string header)
{
    Console.WriteLine(header);
    Console.WriteLine(new string('-', Console.WindowWidth - 1));
    Console.WriteLine($"int   intA:  \t {intA}");
    Console.WriteLine($"int   intA:  \t {intB}");
    Console.WriteLine($"float floatC:\t {floatC}");
    Console.WriteLine($"float floatD:\t {floatD}");
    Console.WriteLine();
}

public static class Swapper
{
    public static void Swap<T1, T2>(ref T1 a, ref T2 b)
    {
        T1 c = a;
        a = (T1)(Convert.ChangeType(b, typeof(T1)) ?? throw new InvalidOperationException("Conversion to T1 failed"));
        b = (T2)(Convert.ChangeType(c, typeof(T2)) ?? throw new InvalidOperationException("Conversion to T2 failed"));
    }
}