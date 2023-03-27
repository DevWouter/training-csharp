// Demo: DateTime and TimeSpan

// DateTime tomorrow = DateTime.Today.AddDays(1);
// DateTime tomorrow_atNoon = dateTime.AddHours(12);
// DateTime tomorrow_atHalfPastNoon = addHours.AddMinutes(30);

var current = DateTime.Today;
DateTime lunchTimeStart = current.AddMonths(1).AddDays(1).AddHours(12).AddMinutes(30);

Console.WriteLine("How many minutes lunch? ");
string answer = Console.ReadLine();
int minutes = int.Parse(answer);

DateTime lunchTimeEnd = lunchTimeStart.AddMinutes(minutes);

Console.WriteLine();
Console.WriteLine("Lunch Time Start:           " + lunchTimeStart);
Console.WriteLine("Lunch Time End:             " + lunchTimeEnd);

// How many minutes until tomorrows lunch?
TimeSpan waitTime = lunchTimeStart - current;
Console.WriteLine();
Console.WriteLine("waitTime:                   " + waitTime);

Console.WriteLine();
Console.WriteLine("waitTime.Days:              " + waitTime.Days);
Console.WriteLine("waitTime.Hours:             " + waitTime.Hours);
Console.WriteLine("waitTime.Minutes:           " + waitTime.Minutes);
Console.WriteLine("waitTime.Seconds:           " + waitTime.Seconds);

Console.WriteLine();
Console.WriteLine("waitTime.TotalDays:         " + waitTime.TotalDays);
Console.WriteLine("waitTime.TotalHours:        " + waitTime.TotalHours);
Console.WriteLine("waitTime.TotalMinutes:      " + waitTime.TotalMinutes);
Console.WriteLine("waitTime.TotalSeconds:      " + waitTime.TotalSeconds);
