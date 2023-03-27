// Console.Write("Enter birthdate: " );
// string birthdateText = Console.ReadLine();
// DateTime birthdate = DateTime.Parse(birthdateText);
DateTime birthdate = new DateTime(1986, 6, 14);

// Calculate age
DateTime current = DateTime.Now;
TimeSpan age = current - birthdate;

Console.WriteLine($"Since your birth the earth has rotated {age.Days} days");
Console.WriteLine($"You have been on earth for {age.TotalMinutes} minutes");

// Assuming you will live to 120 years old how many days do you have left?
DateTime deathDate = birthdate.AddYears(120);
TimeSpan daysLeft = deathDate - current;
Console.WriteLine($"You have {daysLeft.Days} days left to live");

// So how much of your life is left in percentage?
double totalDaysWhen120yearsOld = deathDate.Subtract(birthdate).TotalDays;
double percentage = age.TotalDays / totalDaysWhen120yearsOld;
Console.WriteLine($"You have lived {percentage:P3} of your life");

