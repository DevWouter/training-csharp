try
{
    throw new NotImplementedException("We have not implemented this yet");
}
// ┌ Catch statement
// │   ┌ Catch exception of type Not-Implemented-Exception
// │   │                       ┌ Assign the exception to the variable ex
catch (NotImplementedException ex)
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