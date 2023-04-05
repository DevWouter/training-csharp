// We will cover generic types in more detail later, but for now we will just use them.
// The advantage of a list is that it can grow and shrink in size.

// ┌ Type is `List` of `string` (a list of strings), we call the `string` the "generic type parameter". 
// │         ┌ Variable name
// │         │             ┌ Assign operator
// │         │             │ ┌ Creating an new list
List<string> familyMembers = new List<string>();

// ┌ variable (of type `List<string>`) 
// │          ┌ Add function
// │          │  ┌ Start of the argument list
// │          │  │┌ String literal
// │          │  ││       ┌ End of the argument list
familyMembers.Add("Wouter"); // Me!
familyMembers.Add("Rutger"); // My brother
familyMembers.Add("Joke");   // Mom
familyMembers.Add("Jan");    // Dad
familyMembers.Add("Sirus");  // Dog

// Well, technically the dog is not a family member, so let's remove it
familyMembers.Remove("Sirus");

while (true)
{
    // And printing all the names.
    Console.WriteLine();
    Console.WriteLine("My family members are:");
    foreach (string firstName in familyMembers)
    {
        Console.WriteLine($"- {firstName} Lindenhof");
    }

    Console.Write("Please enter the name of our new family member: ");
    string newFamilyMember = Console.ReadLine();
    if (newFamilyMember == "quit") break; // NOTE: We are using break to exit a while loop

    // Adding the new family member to the list.
    familyMembers.Add(newFamilyMember);
}