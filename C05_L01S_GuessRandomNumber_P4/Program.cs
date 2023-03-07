int AskNumber(string question, int minValue)
{
    // This looks like an infinite loop, but we leave the function using `result`
    while (true)
    {
        Console.Write(question + " ");
        bool isParsed = int.TryParse(Console.ReadLine(), out int result); // 🆕 This try convert text to a number
        if (isParsed)
        {
            if (result >= minValue)
            {
                return result;
            }
            else
            {
                Console.WriteLine($"The number must be greater than or equal to {minValue}");
            }
        }
    }
}

int maxValue = AskNumber("Please enter the maximum value for the random number:", 1);
int randomValue = Random.Shared.Next();
randomValue = randomValue % maxValue;
Console.WriteLine($"Guess a random number in the range of 0-{maxValue}");
int guess = -1;
int attemptsTaken = 0;

while (guess != randomValue)
{
    attemptsTaken++;
    guess = AskNumber($"Please enter a random number between 0-{maxValue}", 0);
    if (guess != randomValue)
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
}

Console.WriteLine($"You guess correct!");
Console.WriteLine($"Attempts: {attemptsTaken}");