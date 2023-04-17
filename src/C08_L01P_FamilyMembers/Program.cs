/*
 * Family member application
 *
 * Complete the application so that the user can manage a family
 *
 * Medals:
 * - Bronze: Perform all TODO_? in the code below
 * - Silver: Print the family members after each command
 * - Gold: Save/Restore more than one family
 * - Platinum: Manage (add,edit,remove) multiple families 
 *
 * Hints:
 * 1. Start with TODO_0 and change the code in THAT function until it does what TODO_0 requires.
 * 2. TODO_1 is the only one that might require multiple lines, all others can be done with a single line of code
 * 3. Use autocomplete (ctrl+space) to see what can be done.
 * 4. Load file only works after you have saved a file
 */

string lastName = "Lindenhof";
List<string> familyMembers = new List<string>();

familyMembers.Add("Wouter"); // Me!

// The line below loops a command until it returns false
while (DisplayCommandWindow()) { }

// -------------------------------------------- >8 --------------------------------------------
// Perform changes below this line, not above (only applies to Bronze medal)
// -------------------------------------------- >8 --------------------------------------------

void ChangeFamilyName()
{
    Console.WriteLine();
    Console.Write("Please enter the new name of the family: ");
    string name = Console.ReadLine();

    // TODO_0: Replace the following line by updating the last name 
    Console.WriteLine("This functionality is not yet implemented");
}

void PrintFamilyMembers()
{
    Console.WriteLine();
    Console.WriteLine("My family members are:");

    // TODO_1: List all family members including their last name
    // EXAMPLE: "- Wouter Lindenhof"
}

void AddFamilyMember()
{
    Console.WriteLine();
    Console.Write("Please enter the name of our new family member: ");
    string name = Console.ReadLine();

    // TODO_2: Add the name to list of family members
    Console.WriteLine("This functionality is not yet implemented");
}

void RemoveFamilyMember()
{
    Console.WriteLine();
    Console.Write("Please enter the name of the family member you want to remove: ");
    string name = Console.ReadLine();

    // TODO_3: Remove a the family member
    Console.WriteLine("This functionality is not yet implemented");
}

void RemoveAllFamilyMembers()
{
    // TODO_3: Remove all members
    Console.WriteLine("This functionality is not yet implemented");
}

// -------------------------------------------- >8 --------------------------------------------
// Perform changes above this line, not below (only applies to Bronze medal)
// -------------------------------------------- >8 --------------------------------------------

void SaveToFile()
{
    var allLines = new List<string>();
    allLines.Add(lastName);
    allLines.AddRange(familyMembers);
    File.WriteAllLines("familyMembers.txt", allLines);
}

void LoadFromFile()
{
    var allLines = File.ReadAllLines("familyMembers.txt");
    lastName = allLines[0];
    familyMembers.Clear();
    for (var i = 1; i < allLines.Length; ++i)
    {
        familyMembers.Add(allLines[i]);
    }
}

bool DisplayCommandWindow()
{
    Console.WriteLine();
    Console.WriteLine($"The family {lastName} has {familyMembers.Count} members.");
    Console.WriteLine("Please select an option:");
    Console.WriteLine("  a) Change family name");
    Console.WriteLine("  b) Add a new family member");
    Console.WriteLine("  c) Remove a family member");
    Console.WriteLine("  d) Print members");
    Console.WriteLine("  e) Remove all family members");
    Console.WriteLine("  s) Save to file");
    Console.WriteLine("  l) Load from file");
    Console.WriteLine("  q) Exit");
    Console.Write("Your choice: ");
    switch (Console.ReadLine().ToLower())
    {
        case "a": 
            ChangeFamilyName();
            return true;
        case "b":
            AddFamilyMember();
            return true;
        case "c": 
            RemoveFamilyMember();
            return true;
        case "d": 
            PrintFamilyMembers();
            return true;
        case "e":
            RemoveAllFamilyMembers();
            return true;
        case "s": 
            SaveToFile();
            return true;
        case "l":
            LoadFromFile();
            return true;
        case "q": 
            return false;
        default:
            Console.WriteLine("Invalid choice, please try again");
            return true;
    }
}