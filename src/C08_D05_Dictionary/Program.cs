// ┌ Type is a `Dictionary` with two generic type parameters (we will cover those later)
// │       ┌ First generic parameter (key)
// │       │       ┌ Second generic parameter (value)
Dictionary<string, string> dictionary_EN_to_NL = new Dictionary<string, string>();


//                      ┌ Key
//                      │       ┌ Value
dictionary_EN_to_NL.Add("Hello", "Hallo");
dictionary_EN_to_NL.Add("Hi", "Hallo"); // We actually use "hoi" in dutch, but this is to prove that we can use the same value for a different key.
// dictionary_EN_to_NL.Add("Hi", "Hoi"); // <-- Adding the same key again will cause an error.
dictionary_EN_to_NL.Add("Goodbye", "Tot ziens");


Console.WriteLine();
Console.WriteLine("These are translations in the dictionary EN -> NL:");


// Using the `foreach` loop to iterate over the dictionary, we store each entry in the variable `kv`.
//       ┌ Type is a `KeyValuePair` with two generic type parameters (we will cover those later)
//       │           ┌ First generic parameter (key)
//       │           │       ┌ Second generic parameter (value)
//       │           │       │       ┌ Variable name
foreach(KeyValuePair<string, string> kv in dictionary_EN_to_NL)
{
    // We can access the key and value of the entry using the `Key` and `Value` properties.
    Console.WriteLine($"{kv.Key} -> {kv.Value}");
}


// ┌ Type is a `Dictionary` with two generic type parameters (we will cover those later)
// │       ┌ First generic parameter (key)
// │       │    ┌ Second generic parameter (value)
Dictionary<int, string> romanNumbers = new Dictionary<int, string>();


// Here the add function is called with two arguments, the first is the key, the second is the value.
// Unlike before, we are not using a string literal, but a number literal.
//               ┌ Key
//               │   ┌ Value
romanNumbers.Add(1, "I");
romanNumbers.Add(2, "II");
romanNumbers.Add(3, "III");
romanNumbers.Add(4, "IV");
romanNumbers.Add(5, "V");
romanNumbers.Add(6, "VI");
romanNumbers.Add(7, "VII");
romanNumbers.Add(8, "VIII");
romanNumbers.Add(9, "IX");
romanNumbers.Add(10, "X");
romanNumbers.Add(11, "XI");
romanNumbers.Add(12, "XII");


Console.WriteLine();
Console.WriteLine("These are translations in the dictionary Arabic numbers -> Roman numbers:");


// Using the `foreach` loop to iterate over the dictionary, but now we "destructor" the value directly into a key and value.
//       ┌ First generic parameter (key)
//       │        ┌ Second generic parameter (value)
foreach((int key, string value) in romanNumbers)
{
    Console.WriteLine($"{key} -> {value}");
}


while(true)
{
    Console.WriteLine();
    Console.Write("Please enter a number: ");
    string input = Console.ReadLine();
    if (input == "quit") break;
    int number = int.Parse(input);
    
    
    if (romanNumbers.ContainsKey(number) == false)
    {
        Console.WriteLine("");
        Console.Write($"This number is not in the dictionary, please write the roman numeral for the arabic number {number}: ");
        string romanNumber = Console.ReadLine();
        
        // Adding the new roman number to the dictionary.
        // Unlike list we need to provide two parameters: the key and the value.
        // The key must be an integer and the value must be a string.
        romanNumbers.Add(number, romanNumber);
    }

    
    Console.WriteLine($"The Roman number for {number} is {romanNumbers[number]}");
}