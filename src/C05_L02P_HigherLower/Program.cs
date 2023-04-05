/*
 * Higher or Lower game
 *
 * The user guesses a random number between 0 and a maximum value. The user is told if their guess is too high or too low.
 *
 * Medals:
 * - Bronze: Display the total number of attempts taken.
 * - Silver: Display the correct amount of times the user guessed too high and too low.
 * - Gold: With each attempt display the lowest number that was too high and the highest number that was too low.
 * - Platinum: Ensure that the user enters a number closer to the random number than the previous guess.
 *             Example: Don't allow the user to enter 33 if the previous guess 40 was too low.
 *
 * Hints:
 * 1. Start with TODO_0
 * 2. Bronze medal requires a single line. You only need to increment a variable.
 * 3. Silver medal requires not 1 but 2 if statements.
 * 4. Gold medal requires two more variables
 * 5. Platinum medal requires replacing a literal and variable with different variables.
 * 6. Again, the `AskNumber` method might give you a few hints
 */


int AskNumber(string question, int minValue, int maxValue)
{
    while (true)
    {
        Console.Write(question + " ");
        bool isParsed = int.TryParse(Console.ReadLine(), out int result); // 🆕 This try convert text to a number
        if (isParsed)
        {
            if (result < minValue)
            {
                Console.WriteLine($"The number must be greater than or equal to {minValue}");
            }else if (result > maxValue)
            {
                Console.WriteLine($"The number must be less than or equal to {maxValue}");
            }
            else
            {
                return result;
            }
        }
    }
}

int maxValue = AskNumber("Enter the maximum value for the random number:", 1, 10000);
int randomValue = Random.Shared.Next();
randomValue %= maxValue;
Console.WriteLine($"Guess a random number in the range of 0-{maxValue}");
int guess = -1;
int attemptsTaken = 0;
int guessedTooHigh = 0;
int guessedTooLow = 0;

while (guess != randomValue)
{
    // TODO_0: Track the number of attempts taken
    Console.WriteLine($"==========================================================");
    Console.WriteLine($"Attempt {attemptsTaken}");
    guess = AskNumber($"Guess between 0-{maxValue}:", 0, maxValue);
}


Console.WriteLine($"You guess correct!");
Console.WriteLine($"Times guessed too high: {guessedTooHigh}");
Console.WriteLine($"Times guessed too low:  {guessedTooLow}");
Console.WriteLine($"Total attempts taken:   {attemptsTaken}");