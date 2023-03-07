using System.Globalization;

int integer = int.Parse("123");
float americanFloatingPoint = float.Parse("234.5", new CultureInfo("en-US"));
float dutchFloatingPoint = float.Parse("234,5", new CultureInfo("nl-NL"));

// Invariant culture is a culture that is not specific to any region and is commonly used for
// parsing numbers that are not localized (like how developers write numbers).
float invariantFloatingPoint = float.Parse("234.5", CultureInfo.InvariantCulture);

Console.WriteLine($"Parsed \"123\"   as invariant       integer -> {integer}");
Console.WriteLine($"Parsed \"234.5\" as        US FloatingPoint -> {americanFloatingPoint}");
Console.WriteLine($"Parsed \"234,5\" as        NL FloatingPoint -> {dutchFloatingPoint}");
Console.WriteLine($"Parsed \"234.5\" as invariant FloatingPoint -> {invariantFloatingPoint}");
