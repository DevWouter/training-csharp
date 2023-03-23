try
{
    throw new NotImplementedException("Oh no! We forgot to implement this!");
}
// ┌ Catch statement
// │   ┌ Catch exception of type Not-Implemented-Exception
// │   │                       ┌ Assign the exception to the variable ex
// │   │                       │   ┌ When-keyword
// │   │                       │   │     ┌ The exception message is equal to this string
catch (NotImplementedException ex) when (ex.Message == "We have not implemented this yet")
{ // Start of catch block 
    Console.WriteLine($"Not everything is done: {ex}");
} // End of catch block
// ┌ Catch statement
// │   ┌ Catch exception of type Exception
// │   │         ┌ Assign the exception to the variable ex
catch (Exception ex)
{ // Start of catch block 
    Console.WriteLine($"We tried something and failed: {ex}");
} // End of catch block