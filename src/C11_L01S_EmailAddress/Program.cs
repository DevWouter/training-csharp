// EmailAddress
//
// Goal: Create a constructor and implicit conversion.
//       Except where TODO_? says uncomment you can only change code where scissors are.
// 
// Medals:
// [🥉] Create a constructor that takes a string and stores the localpart and the domain part
// [🥈] Implement `ToString` so that it returns `[Local=..., Domain=...]` and demonstrate it by printing it to the screen 
// [🥇] Implement an operator that takes a string and converts it to a type 
// [🏆] Implement an operator that takes a EmailAddress and converts it to string
//
// Tips:
// 1. Only uncomment the next TODO_? when you have completed the previous one.
// 2. `ToString` requires an override
// 3. Operators are always static
// 4. If you wonder how to split a string take a look at the FullAddress property (we don't use the set-property)

Console.WriteLine("Email Address");

/* For the bronze medal it should print `Bronze: email.FullAddress = constructor@example.com` */
/* TODO_0: Make the following lines work (no need to uncomment things) */
EmailAddress email = new EmailAddress("constructor@example.com");
Console.WriteLine($"Bronze:   email.FullAddress = {email.FullAddress}");

/* For the silver medal it should print `Silver: email.ToString() = [Local=constructor, Domain=example.com]` */
/* TODO_1: Uncomment the following 1 lines when you have completed bronze */
Console.WriteLine($"Silver:   email.ToString() = {email}");

/* For the gold medal it should print `Gold:     email.ToString() = [Local=implicit, Domain=example.com]` */
/* TODO_2: Uncomment the following 2 lines when you have completed silver */
email = "implicit@example.com";
Console.WriteLine($"Gold:     email.ToString() = {email}");

/* For the platinum medal it should print `Platinum: emailString = implicit@example.com` */
/* TODO_3: Uncomment the following 2 lines when you have completed gold */
string emailString = email;
Console.WriteLine($"Platinum: emailString = {emailString}");


public class EmailAddress
{
    public string LocalPart { get; set; }
    public string Domain { get; set; }

    public string FullAddress
    {
        get { return $"{LocalPart}@{Domain}"; }
        set
        {
            LocalPart = value.Split('@')[0];
            Domain = value.Split('@')[1];
        }
    }
    
    // --------------------------------- >8 -----------------------------------------------
    // TODO_0: Create constructor
    public EmailAddress(string source)
    {
        LocalPart = source.Split('@')[0];
        Domain = source.Split('@')[1];
    }

    // TODO_1: Create ToString()
    public override string ToString()
    {
        return $"[Local={LocalPart}, Domain={Domain}]";
    }

    // TODO_2: Implement operator to convert string to EmailAddress
    public static implicit operator EmailAddress(string source)
    {
        return new EmailAddress(source);
    }

    // TODO_3: Implement operator to convert EmailAddress to string
    public static implicit operator string(EmailAddress source)
    {
        return source.FullAddress;
    }
    // --------------------------------- >8 -----------------------------------------------
}