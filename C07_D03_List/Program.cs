// We will cover generic types in more detail later, but for now we will just use them.
// The advantage of a list is that it can grow and shrink in size.

// ┌ Type is `List` of `string` (a list of strings), we call the `string` the "generic type parameter". 
// │         ┌ Variable name
// │         │             ┌ Assign operator
// │         │             │ ┌ Creating an new list
List<string> familyMembers = new List<string>();
familyMembers.Add("Wouter"); // Me!
familyMembers.Add("Rutger"); // My brother
familyMembers.Add("Joke");   // Mom
familyMembers.Add("Jan");    // Dad
familyMembers.Add("Sirus");  // Dog

while(true)
{
    Console.Write("Please enter the name of our new family member: ");
    string newFamilyMember = Console.ReadLine();
    if(newFamilyMember == "")
        break;     // NOTE: We are using break to exit a while loop

    // Adding more elements to the list
    familyMembers.Add(newFamilyMember);
}


// And printing all the names.
foreach (string firstName in familyMembers)
{
    Console.WriteLine($"- {firstName} Lindenhof");
}