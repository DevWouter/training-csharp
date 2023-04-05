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

TimeSpan waitTime_minus_2_days = waitTime.Subtract(TimeSpan.FromDays(2));
TimeSpan waitTime_minus_5_days = waitTime - TimeSpan.FromDays(5);

Console.WriteLine();
Console.WriteLine("waitTime_minus_2_days:      " + waitTime_minus_2_days);
Console.WriteLine("waitTime_minus_5_days:      " + waitTime_minus_5_days);

// But what date is that?
DateTime early_by_2_days_date = lunchTimeStart - TimeSpan.FromDays(2);
DateTime early_by_5_days_date = current + waitTime_minus_5_days;

Console.WriteLine();
Console.WriteLine("early_by_2_days_date:       " + early_by_2_days_date);
Console.WriteLine("early_by_5_days_date:       " + early_by_5_days_date);


Console.WriteLine();
Console.WriteLine($"lunchTimeStart             {lunchTimeStart}");
Console.WriteLine($"early_by_5_days_date       {early_by_5_days_date}");
Console.WriteLine($"=============================================== - (subtraction)");
Console.WriteLine($"                           {lunchTimeStart - early_by_5_days_date}");