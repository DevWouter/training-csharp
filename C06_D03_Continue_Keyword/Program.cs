Console.WriteLine("All leap years between 1990 and 2040:");
for(int year = 1990; year < 2040; year++)
{
    // Check if the year is a leap year
    bool isLeapYear = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    bool isNotLeapYear = !isLeapYear;
    
    if (isNotLeapYear)
    {
        // The continue statement skips the rest of the current iteration and continues with the next iteration.
        // It still executes the increment statement
        continue;
    }
        
    Console.WriteLine($"- {year}");
}