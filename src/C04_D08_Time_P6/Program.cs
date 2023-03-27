var current = DateTime.Now;

// Parse is a method that can be used to convert a string to a DateTime.
// We will cover only two formats here:
// - "yyyy-MM-dd"
// - "yyyy-MM-ddTHH:mm:ss.fffffff"

var startOfMillennium = DateTime.Parse("2000-01-01");
var endOfMillennium = DateTime.Parse("3000-12-31T23:59:59.9999999");

Console.WriteLine("startOfMillennium:          " + startOfMillennium);
Console.WriteLine("current:                    " + current);
Console.WriteLine("endOfMillennium:            " + endOfMillennium);

Console.WriteLine();

// Days in Millennium
TimeSpan timeInMillennium = endOfMillennium - startOfMillennium;
Console.WriteLine("daysInMillennium.TotalDays:            " + timeInMillennium.TotalDays);

// Days since Millennium
TimeSpan timeSinceMillennium = current - startOfMillennium;
var totalDaysSinceMillennium = timeSinceMillennium.TotalDays;
Console.WriteLine("daysSinceMillennium.TotalDays:         " + totalDaysSinceMillennium);

// At what percentage of the Millennium are we?
var percentage = totalDaysSinceMillennium / timeInMillennium.TotalDays;
Console.WriteLine($"percentage in to the millennium:       {percentage:P3}");