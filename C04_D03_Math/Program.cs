#region Fix for console output not printing infinity symbol
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
#endregion

Header("Normal math");
Console.WriteLine($"-19 = {-19}"); // Negate operator
Console.WriteLine($"7 + 9 = {7 + 9}");
Console.WriteLine($"12 - 4 = {12 - 4}");
Console.WriteLine($"3 * 5 = {3 * 5}");
Console.WriteLine($"16 / 2 = {16 / 2}");
Console.WriteLine($"11 % 3 = {11 % 3}"); // 11 divided by 3 is 3 with a remainder of 2

// NOTE: Post-increment or post-decrement operators are evaluated AFTER the expression is evaluated
//       Pre-increment or pre-decrement operators are evaluated BEFORE the expression is evaluated
// TIP:  To prevent confusion simply store the result of the increment or decrement in a variable and then
//       use that variable.  
Header("Increment and decrement operators");
int number = 9;
Console.WriteLine($"When number is {number}: ++number = {++number} (pre-increment)");
number = 9;
Console.WriteLine($"When number is {number}: --number = {--number} (pre-decrement)");
number = 9;
Console.WriteLine($"When number is {number}: number++ = {number++} (post-increment)");
number = 9;
Console.WriteLine($"When number is {number}: number-- = {number--} (post-decrement)");

Header("Bitshift");
// Bit-shifting moves the bits of a number to the left or right
// Since computers use a binary system, you can think of bitshifting as multiplying or dividing by 2
Console.WriteLine($"2 << 1 = {(2 << 1)}");
Console.WriteLine($"8 << 2 = {(8 << 2)}");
Console.WriteLine($"128 >> 1 = {(128 >> 1)}");
Console.WriteLine($"64 >> 4 = {(64 >> 4)}");

Header("Bitwise operators");
// Bitwise operators
byte a = 0b_1010_0101;
byte b = 0b_0000_1111;

Console.WriteLine("Bitwise AND"); // 1 if both bits are 1, otherwise 0
Console.WriteLine($"(a & b) = {ToBinary(a)} & {ToBinary(b)} = {ToBinary(a & b)}");
Console.WriteLine($"(b & a) = {ToBinary(b)} & {ToBinary(a)} = {ToBinary(b & a)}");

Console.WriteLine("Bitwise OR"); // 1 if either bit is 1
Console.WriteLine($"(a | b) = {ToBinary(a)} | {ToBinary(b)} = {ToBinary(a | b)}");
Console.WriteLine($"(b | a) = {ToBinary(b)} | {ToBinary(a)} = {ToBinary(b | a)}");

Console.WriteLine("Bitwise XOR"); // Exclusive OR. Only one of the bits can be 1, but not both
Console.WriteLine($"(a ^ b) = {ToBinary(a)} ^ {ToBinary(b)} = {ToBinary(a ^ b)}");
Console.WriteLine($"(b ^ a) = {ToBinary(b)} ^ {ToBinary(a)} = {ToBinary(b ^ a)}");

Console.WriteLine("Bitwise Negation"); // Flips all bits. 0 becomes 1, and 1 becomes 0
Console.WriteLine($"(~a) = ~{ToBinary(a)} = {ToBinary((byte)~a)}");
Console.WriteLine($"(~b) = ~{ToBinary(b)} = {ToBinary((byte)~b)}");

Header("Compound assignment operators");
// Compound assignment operators
// These operators combine an assignment with an operation
int value = 0;
Console.WriteLine($"value  = {value};  value is {value}");
value += 12;
Console.WriteLine($"value += 12; value is {value}");
value -= 4; 
Console.WriteLine($"value -= 4;  value is {value}");
value *= 7;
Console.WriteLine($"value *= 7;  value is {value}");
value %= 10;
Console.WriteLine($"value %= 10; value is {value}");
value /= 3;
Console.WriteLine($"value /= 3;  value is {value}");

// Mostly the same as integer math.
Header("Floating point math");
Console.WriteLine($"integer: 10f / 3f = {10 / 3}");
Console.WriteLine($"float:   10f / 3f = {10f / 3f}");
Console.WriteLine($"double:  10d / 3d = {10d / 3d}");
Console.WriteLine($"decimal: 10f / 3m = {10m / 3m}");

// Special values (these also exist for double and decimal and some also exist for integer types)
Header("Special values");
Console.WriteLine($"double.MinValue         = {double.MinValue}");
Console.WriteLine($"double.MaxValue         = {double.MaxValue}");
Console.WriteLine($"double.Epsilon          = {double.Epsilon}");
Console.WriteLine($"double.NaN              = {double.NaN}");
Console.WriteLine($"double.NegativeInfinity = {double.NegativeInfinity}");
Console.WriteLine($"double.PositiveInfinity = {double.PositiveInfinity}");

// Computers use a binary system, even for floating point numbers
// This means that some numbers cannot be represented exactly
// For example, 0.1 cannot be represented exactly in binary
// This is why you should not use floating point numbers for money
Header("Proof that floating point is not exact");
float bill = 12.10f; 
Console.WriteLine(       "Bill:                      " + bill);
float tip = AskForFloat($"Amount of tip (like: {1.1})");
float total = bill + tip;
Console.WriteLine($"Bill: {bill} + Tip: {tip} = Total: {total}");

Console.WriteLine("\n\nPress any key to continue...");
Console.ReadKey();


#region Helper methods

// These helper methods are used to make the code more readable.
// They are bit more advanced than what we have learned so far and will be explained later.

string ToBinary(int value)
{
    return $"0b{Convert.ToString(value, 2).PadLeft(8, '0')}";
}

void Header(string text)
{
    Console.WriteLine();
    Console.WriteLine(text);
    Console.WriteLine("=====================================================");
}

float AskForFloat(string question)
{
    Console.Write($"{question}: ");
    string text = Console.ReadLine();
    return float.Parse(text);
}

#endregion
