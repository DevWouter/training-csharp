try
{
    throw new Exception($"Something has gone wrong");
}
// ┌ Catch statement
// │   ┌ Catch exception of type Exception
// │   │         ┌ Assign the exception to the variable ex
catch (Exception ex)
{ // Start of catch block 
    Console.WriteLine($"We tried something and failed: {ex}");
} // End of catch block