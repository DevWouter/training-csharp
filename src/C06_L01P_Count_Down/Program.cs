/*
 * GOAL: Modify the program so that it counts down from 10 to 0.
 * 
 * Example output:
 * 
 *    10
 *    9
 *    8
 *    ...>8...
 *    2
 *    1
 *    0
 *
 * Bonus: Modify the program so that it counts down from 10 to 0, but instead of "2, 1, 0" it says "Ready, Set, Go!"
 *
 * Hints:
 * 1. You don't need to use continue or break.
 * 2. With which number should you start the loop?
 * 3. How should we "increment" the value?
 * 4. When should we stop the loop?
 * 5. For the bonus we could use an if statement
 */


// NOTE: This for loop counts up from 0 to 9, while it should be counting down from 10 to 0.
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}