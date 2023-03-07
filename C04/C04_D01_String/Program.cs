// So far we have only worked with strings, now lets look at some other ways of using strings.

string name = "world"; // A string literal being stored in a variable of type string.

// We can use the + operator to combine two strings.
// Also called concatenation.
Console.WriteLine("Hello, " + name + "!");

// We can use the $ operator to combine a string literal with a variable.
// Also called string interpolation.
Console.WriteLine($"Hello, {name}!");

// 🚫 Wrong
string wrongInterpolatedString1 = "Hello, {name}!"; // NOTE: Missing the dollar sign.
string wrongInterpolatedString2 = $"Hello, [name)!"; // NOTE: Wrong brackets.

// We can also use escape characters to include special characters in a string.
Console.WriteLine("Escaping strings");
Console.WriteLine("================"); // NOTE: The backslash escapes the double quote.

string escapedString = "Hello, \"world\"!"; // Normally the double quotes would end the string literal.
Console.WriteLine(escapedString);

// Here we escape the escape character.
Console.WriteLine("Or we can use \\n to split \ntext \nover \nmultiple \nlines.");

// Verbatim STRINGS
Console.WriteLine("Verbatim strings");
Console.WriteLine("================");

// NOTE: The @ symbol also makes the string literal "verbatim" meaning that the escape characters are ignored.
Console.WriteLine(@"Hello, \""world\""! No \n newlines \n here");


Console.WriteLine("RAW strings");
Console.WriteLine("================");
// Raw STRINGS
string xml = """
            <xml>
                Notice that the leading spaces are ignored.
                <question>What are leading spaces?</question>
                <answer>Spaces at the start of the line.</answer>
            </xml>
            """;

string xmlVerbatim = @"
            <xml>
                <node>Sadly verbatim strings don't have that.</node>
            </xml>
            ";

string needMoreQuotes = """"""""Sure you can have more """quotes""" in your quotes. Just add more quotes."""""""";

Console.WriteLine("-----------");
Console.WriteLine(xml);
Console.WriteLine("-----------");
Console.WriteLine(xmlVerbatim);
Console.WriteLine("-----------");
Console.WriteLine(needMoreQuotes);
Console.WriteLine("-----------");



