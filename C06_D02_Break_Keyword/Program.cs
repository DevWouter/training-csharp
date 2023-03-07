string first10Letters = "abcdefghij";

// In the code below we iterate over the string `first10Letters` using a `for` loop
// Normally we would use the commented out code below, but for this demo we are going to use
// a break in an infinite for-loop
//
//     for (int i = 0; i < 10; ++i)
//     {
//         char letter = first10Letters[i];
//         Console.WriteLine($"The letter at index {i} of {first10Letters} is {letter}");
//     }
//
// 

int index = 0; // We moved the initialization of index out of the loop

// This is an infinite loop, no initializer, condition or increment statement
// We can replace it with `while(true)` and it would do the exact same thing
for (;;)
{
    // ┌ 🆕 Type: Char is a type that can hold a single character
    // │                        ┌ 🆕 indexer: Looks up the character at the given index notice the square brackets 
    // │                        │ ┌ The location of the character to look up
    char letter = first10Letters[index];
    Console.WriteLine($"The letter at index {index} of {first10Letters} is {letter}");
    
    // Here is our increment statement
    index++;


    // Condition statement
    if (index == 10)
    {
        // ┌ 🆕 break: Breaks out of the current loop
        break;
    }
}