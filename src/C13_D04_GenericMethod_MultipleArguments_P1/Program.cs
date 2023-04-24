int intA = 1;
int intB = 2;

float floatC = 3.0f;
float floatD = 4.0f;

PrintAllVariables("Initial value");

Swapper.Swap<int>(ref intA, ref intB);
Swapper.Swap<float>(ref floatC, ref floatD);
PrintAllVariables("After swapping both");

// This won't work since inferred types are different
// Swapper.Swap(ref intA, ref floatD);

// Which is obvious since we are using the generic version
// Swapper.Swap<int>(ref intA, ref floatD);

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
    /// <summary>
    ///     Swaps the values
    /// </summary>
    public static void Swap<T>(ref T a, ref T b)
    {
        T c = a;
        a = b;
        b = c;
    }
}