int intA = 1;
int intB = 2;

float floatC = 3.0f;
float floatD = 4.0f;

PrintAllVariables("Initial value");

Swapper.Swap(ref intA, ref intB);
Swapper.Swap(ref floatC, ref floatD);
PrintAllVariables("After swapping both");

// This will work since we overloaded the method for a specific type
Swapper.Swap(ref intA, ref floatD);
PrintAllVariables("After swapping using the overloaded method");

// But the other way is not allowed 
// Swapper.Swap(ref floatC, ref intB);

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
    public static void Swap<T>(ref T a, ref T b)
    {
        T c = a;
        a = b;
        b = c;
    }

    public static void Swap(ref int a, ref float b)
    {
        int c = a;
        a = (int)b;
        b = c;
    }
}