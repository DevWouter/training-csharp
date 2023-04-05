#region Fix for console output not printing infinity symbol
using System.Text;
using System.Globalization;
Console.OutputEncoding = Encoding.UTF8;
#endregion


// Setting the values
int integer = 42;
double pi = Math.PI;


// NOTE: The culture determines how numbers are formatted, e.g. decimal separator
//       The value in the comments is for the en-US culture

// Print the values using format specifiers
Console.WriteLine();
Console.WriteLine("Printing integer");
Console.WriteLine("-----------------");
Console.WriteLine(integer.ToString()); // Writes "42"
Console.WriteLine(integer.ToString("D5")); // Writes "00042"
Console.WriteLine(integer.ToString("x8")); // Writes "0000002a"
Console.WriteLine(integer.ToString("F2")); // Writes "42.00"

Console.WriteLine();
Console.WriteLine("Printing Pi");
Console.WriteLine("-----------");
Console.WriteLine(pi.ToString());      // Writes "3.14159265358979"
Console.WriteLine(pi.ToString("F10")); // Writes "3.1415926536"
Console.WriteLine(pi.ToString("F2"));  // Writes "3.14"
Console.WriteLine(pi.ToString("E1"));  // Writes "3.1E+00"

// Want to format it in another language?
Console.WriteLine();
Console.WriteLine("Printing Money");
Console.WriteLine("--------------");
Console.WriteLine("Money in en-US: " + pi.ToString("C", new CultureInfo("en-US")));
Console.WriteLine("Money in nl-NL: " + pi.ToString("C", new CultureInfo("nl-NL")));
Console.WriteLine("Money in fr-FR: " + pi.ToString("C", new CultureInfo("fr-FR")));
