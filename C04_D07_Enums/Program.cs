Console.WriteLine("Month 1 is in financial quarter: " + GetFinancialQuarterNumberByMonth(1));
Console.WriteLine("Month 2 is in financial quarter: " + GetFinancialQuarterNumberByMonth(2));
Console.WriteLine("Month 3 is in financial quarter: " + GetFinancialQuarterNumberByMonth(3));
Console.WriteLine("Month 4 is in financial quarter: " + GetFinancialQuarterNumberByMonth(4));
Console.WriteLine("Month 5 is in financial quarter: " + GetFinancialQuarterNumberByMonth(5));
Console.WriteLine("Month 6 is in financial quarter: " + GetFinancialQuarterNumberByMonth(6));
Console.WriteLine("Month 7 is in financial quarter: " + GetFinancialQuarterByMonth(7));
Console.WriteLine("Month 8 is in financial quarter: " + GetFinancialQuarterByMonth(8));
Console.WriteLine("Month 9 is in financial quarter: " + GetFinancialQuarterByMonth(9));
Console.WriteLine("Month 10 is in financial quarter: " + GetFinancialQuarterByMonth(10));
Console.WriteLine("Month 11 is in financial quarter: " + GetFinancialQuarterByMonth(11));
Console.WriteLine("Month 12 is in financial quarter: " + GetFinancialQuarterByMonth(12));

Console.WriteLine("Month 0 is in financial quarter: " + GetFinancialQuarterByMonth(0));


int GetFinancialQuarterNumberByMonth(int month)
{
    if (month <= 0) return -1; // Invalid
    if (month <= 3) return 1;
    if (month <= 6) return 2;
    if (month <= 9) return 3;
    if (month <= 12) return 4;
    return -1; // Invalid
}

FinancialQuarter GetFinancialQuarterByMonth(int month)
{
    if (month <= 0) return FinancialQuarter.Invalid;
    if (month <= 3) return FinancialQuarter.FirstQuarter;
    if (month <= 6) return FinancialQuarter.SecondQuarter;
    if (month <= 9) return FinancialQuarter.ThirdQuarter;
    return FinancialQuarter.FourthQuarter;
}

// ┌ enum keyword
// │ ┌ name of the enum
enum FinancialQuarter
{ // Start of the enum values
    // ┌ Name of the enum value 
    FirstQuarter,   // Enums are zero-based, so this will be 0
    SecondQuarter,  // This will be 1
    ThirdQuarter,   // This will be 2
    FourthQuarter,  // This will be 3
    
    // ┌ Name of the enum value
    // │    ┌ Assign operator
    // │    │ ┌ Value of the enum value
    Invalid = -1,
}