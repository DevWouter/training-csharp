// Using the for-loop is a bit verbose but we can also use a foreach-loop to loop over the array.
// The only downside is that we can't use the index to access the array.

// ┌ Type is `string[]` (an array of strings)
// │     ┌ Variable name
// │     │          ┌ Assign operator
// │     │          │     ┌ Creating an array of 5 elements
string[] familyMembers = new string[5];
familyMembers[0] = "Wouter"; // Me!
familyMembers[1] = "Rutger"; // My brother
familyMembers[2] = "Joke";   // Mom
familyMembers[3] = "Jan";    // Dad
familyMembers[4] = "Sirus";  // Dog

string lastName = "Lindenhof";

// ┌ foreach keyword
// │     ┌ Type of the elements in the array
// │     │      ┌ Variable name that we store the value from the array in
// │     │      │         ┌ in keyword
// │     │      │         │  ┌ Array that we want to loop over
foreach (string firstName in familyMembers)
{
    string fullName = firstName + " " + lastName;
    Console.WriteLine($"- {fullName}");
}