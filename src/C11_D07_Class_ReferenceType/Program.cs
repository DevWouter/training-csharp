// Explain that classes are reference types

FamilyMember member = new FamilyMember();
member.FirstName = "???";
member.LastName = "???";

UpdateFirstName(member, "Wouter");
UpdateLastName(member, "Lindenhof");

Console.WriteLine("The Firstname is: " + member.FirstName);
Console.WriteLine("The LastName is: " + member.LastName);

void UpdateFirstName(FamilyMember dst, string firstName)
{
    // dst stands for destination
    dst.FirstName = firstName;
}

void UpdateLastName(FamilyMember dst, string lastName)
{
    dst.LastName = lastName;
}

public class FamilyMember
{
    public string FirstName;
    public string LastName;
} 