bool yes = true;
bool no = false;

Console.WriteLine();
Console.WriteLine("Operators");
Console.WriteLine("===============================");
// Compare operators
Console.WriteLine($"yes == no \t{yes} == {no} \t{yes == no}");
Console.WriteLine($"yes != no \t{yes} != {no} \t{yes == no}");

Console.WriteLine();
Console.WriteLine("Negate operators");
Console.WriteLine("===============================");
// Negation operator
Console.WriteLine($"!yes \t!{yes} \t{!yes}");
Console.WriteLine($"!no \t!{no} \t{!no}");


// Truth table for the AND operator
Console.WriteLine();
Console.WriteLine("Truth table for the AND operator");
Console.WriteLine("===============================");
Console.WriteLine("A\tB\tA && B");
Console.WriteLine("true\ttrue\t{0}", true && true);
Console.WriteLine("true\tfalse\t{0}", true && false);
Console.WriteLine("false\ttrue\t{0}", false && true);
Console.WriteLine("false\tfalse\t{0}", false && false);

// Truth table for the OR operator
Console.WriteLine();
Console.WriteLine("Truth table for the OR operator");
Console.WriteLine("===============================");
Console.WriteLine("A\tB\tA || B");
Console.WriteLine("true\ttrue\t{0}", true || true);
Console.WriteLine("true\tfalse\t{0}", true || false);
Console.WriteLine("false\ttrue\t{0}", false || true);
Console.WriteLine("false\tfalse\t{0}", false || false);


// Comparing numbers results in a boolean
Console.WriteLine();
Console.WriteLine("Comparing numbers");
Console.WriteLine("===============================");
int leftNumber = 10;
int rightNumber = 20;
Console.WriteLine($"leftNumber == rightNumber \t {leftNumber} == {rightNumber} \t {leftNumber == rightNumber}");
Console.WriteLine($"leftNumber != rightNumber \t {leftNumber} != {rightNumber} \t {leftNumber != rightNumber}");
Console.WriteLine($"leftNumber <  rightNumber \t {leftNumber} <  {rightNumber} \t {leftNumber < rightNumber}");
Console.WriteLine($"leftNumber <= rightNumber \t {leftNumber} <= {rightNumber} \t {leftNumber <= rightNumber}");
Console.WriteLine($"leftNumber >  rightNumber \t {leftNumber} >  {rightNumber} \t {leftNumber > rightNumber}");
Console.WriteLine($"leftNumber >= rightNumber \t {leftNumber} >= {rightNumber} \t {leftNumber >= rightNumber}");

// Comparing numbers results in a boolean
Console.WriteLine();
Console.WriteLine("Comparing numbers");
Console.WriteLine("===============================");
string leftString = "Hello";
string rightString = "World";
Console.WriteLine($"leftString == rightString \t {leftString} == {rightString} \t {leftString == rightString}");
Console.WriteLine($"leftString != rightString \t {leftString} != {rightString} \t {leftString != rightString}");

// NOTE: The >, >=, <= and < operators do not exist for string
