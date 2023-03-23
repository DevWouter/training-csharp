// Fibonacci
//
// Goal: Change the code so that it uses the yield keyword to return the next number in the sequence.
//       - Without hard coding the entire sequence.
//       - Without changing the code outside the Fibonacci() method.
//
// Background: the Fibonacci sequence is a sequence in which each number is the sum of the two preceding ones, starting from 0 and 1.
// The expected output should be:  1, 2, 3, 5, 8, 13, 21, 34, 55, 89.
//
// Hints:
// - You need `yield return` instead of `yield break`
// - Keep the for-loop, because the sequence is infinite we are only interested in the first 10 numbers
// - The only literal numbers you need are 0 and 1 (and 10 for the loop, but that doesn't count)
// - If you need the next number remember that it always the sum of the previous two (e.g. 13 = 8 + 5)

foreach (var goldenNumber in Fibonacci())
{
    Console.WriteLine(goldenNumber);
}

IEnumerable<int> Fibonacci()
{
    // -------------------------------------------- >8 --------------------------------------------
    for(var i = 0; i < 10; ++i)
    {
        yield break;
    }
    // -------------------------------------------- >8 --------------------------------------------
}