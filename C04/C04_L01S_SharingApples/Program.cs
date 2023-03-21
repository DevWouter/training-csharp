int totalApples = Random.Shared.Next(1, 100); // Random number between 1 and 100
int numberOfStudents = 20;

Console.WriteLine($"There are {totalApples} apples and {numberOfStudents} students.");

// DONE_1: Calculate and print the number of apples each student gets.
int applesPerStudent = totalApples / numberOfStudents;
Console.WriteLine($"Each student gets {applesPerStudent} apples.");

// DONE_2: Calculate and print the number of apples left over.
int applesLeftOver = totalApples % numberOfStudents;
Console.WriteLine($"There are {applesLeftOver} apples left over.");

// DONE_3: Check and print if the amount of apples left over is more than half the students.
int halfOfStudents = numberOfStudents / 2;
bool moreThanHalf = applesLeftOver > halfOfStudents;
Console.WriteLine($"There are more than half the students left over: {moreThanHalf}");
