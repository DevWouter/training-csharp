﻿int AskNumber(string question, int minValue, int maxValue)
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
int guess = maxValue;
int attemptsTaken = 0;
int guessedTooHigh = 0;
int guessedTooLow = 0;

while (guess != randomValue)
{
    attemptsTaken++;
    Console.WriteLine($"==========================================================");
    Console.WriteLine($"Attempt {attemptsTaken}");
    guess = AskNumber($"Guess between 0-{maxValue}:", 0, maxValue);
    
}

Console.WriteLine($"You guess correct!");
Console.WriteLine($"Times guessed too high: {guessedTooHigh}");
Console.WriteLine($"Times guessed too low:  {guessedTooLow}");
Console.WriteLine($"Total attempts taken:   {attemptsTaken}");