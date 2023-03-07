int AskNumber(string question)
{
    // This looks like an infinite loop, but we leave the function using `result`
    while (true)
    {
        Console.Write(question + " ");
        bool isParsed = int.TryParse(Console.ReadLine(), out int result); // 🆕 This try convert text to a number
        if (isParsed)
        {
            return result;
        }
    }
}

int randomValue = Random.Shared.Next();
randomValue = randomValue % 10;
Console.WriteLine($"Guess a random number in the range of 0-10:");
int guess = -1;

while (guess != randomValue)
{
    guess = AskNumber($"Please enter a random number between 0-10:");
    if (guess != randomValue)
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
}

Console.WriteLine($"You guess correct!");
