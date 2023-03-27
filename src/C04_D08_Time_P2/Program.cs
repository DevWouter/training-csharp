
// We store the current date and time in a variable because time is always changing.
// So the variable `current` is actually always out of date.
// Same as with pictures: They are always represent a younger you.
DateTime current = DateTime.Now;

Console.WriteLine("DateTime.Now:               " + current);
Console.WriteLine("DateTime.Now.Year:          " + current.Year);
Console.WriteLine("DateTime.Now.Month:         " + current.Month);
Console.WriteLine("DateTime.Now.Day:           " + current.Day);

Console.WriteLine();
Console.WriteLine("DateTime.Now.DayOfWeek:     " + current.DayOfWeek);
Console.WriteLine("DateTime.Now.DayOfYear:     " + current.DayOfYear);

Console.WriteLine();
Console.WriteLine("DateTime.Now.Hour:          " + current.Hour);
Console.WriteLine("DateTime.Now.Minute:        " + current.Minute);
Console.WriteLine("DateTime.Now.Second:        " + current.Second);
Console.WriteLine("DateTime.Now.Millisecond:   " + current.Millisecond);
Console.WriteLine("DateTime.Now.Microsecond:   " + current.Microsecond);
Console.WriteLine("DateTime.Now.Nanosecond:    " + current.Nanosecond);

Console.WriteLine();
Console.WriteLine("DateTime.Now.Date:          " + current.Date);
Console.WriteLine("DateTime.Now.TimeOfDay:     " + current.TimeOfDay);
Console.WriteLine("DateTime.Now.Ticks:         " + current.Ticks);


