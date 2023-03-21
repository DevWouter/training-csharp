// So far we only used variables that can contain only a single value.
// But with an array we can store multiple values in a single variable.
// NOTE: When using arrays we often use square brackets `[]` to indicate index and size.

// ┌ Type is `string[]` (an array of strings)
// │     ┌ Variable name
// │     │          ┌ Assign operator
// │     │          │     ┌ Creating an array of 5 elements
string[] familyMembers = new string[5];


// ┌ Variable name
// │         ┌ Index of the element in the array we want to change
// │         │   ┌ Assign operator
// │         │   │ ┌ String literal
familyMembers[0] = "Wouter"; // Me!
familyMembers[1] = "Rutger"; // My brother
familyMembers[2] = "Joke";   // Mom
familyMembers[3] = "Jan";    // Dad
familyMembers[4] = "Sirus";  // Dog


// familyMembers[5] = "Whoops"; // ERROR: Index was outside the bounds of the array.


// We can then loop over the array and print all the names
for (int i = 0; i < familyMembers.Length; i++)
{
    // ┌ Variable type
    // │   ┌ Variable name
    // │   │         ┌ Assign operator
    // │   │         │ ┌ Array name
    // │   │         │ │            ┌ Index of the element we want to access
    string firstName = familyMembers[i];

    Console.WriteLine($"- {firstName} Lindenhof");
}