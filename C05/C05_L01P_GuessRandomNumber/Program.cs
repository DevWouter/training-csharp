/*
 * Assignment: Guess the random number.
 *
 * There are four medals for this assignment:
 * - Bronze: The application runs and continues to ask the user to guess the random number until they guess correctly.
 * - Silver: Same as Bronze, but we also keep track of the number of attempts it took the user to guess correctly.
 * - Gold: Same as Silver, but we also ask the user to enter the maximum value for the random number using `AskNumber`
 * - Platinum: Same as Gold, but we check if AskNumber has a valid range. 
 *
 * TIPS
 * 1. Start with the `TODO_1` and complete it before moving on to `TODO_2`
 * 2. For TODO_1 you can introduce a variable named `guess`
 * 3. For TODO_3 you need a boolean variable
 * 4. You don't need to functions, but you do need `if` and a `while` statements
 * 5. Forgot how to use `if` and `while`? Check out the `AskNumber` method
 */

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
Console.WriteLine("Guess a random number in the range of 0-10");


// TODO_1: Ask the user to guess a number between 0 and 10 using `AskNumber`
// TODO_2: Compare the user's guess to the random value
// TODO_3: If the user guessed correctly, print "You guess correct!"
// TODO_4: If the user guessed incorrectly, print "You guessed wrong, try again!"
// TODO_5: Put the code in a loop so the user can keep guessing until they get it right