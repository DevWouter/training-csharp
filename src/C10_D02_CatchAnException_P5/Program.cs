int counter = 0;
int successCounter = 0;
int failureCounter = 0;
int totalCounter = 0;

for (var i = 0; i < 100; ++i)
{
    try
    {
        UnreliableIncrementor();
        successCounter++;
    }
    catch
    {
        failureCounter++;
        if (failureCounter > 30) break; // Let's stop after 30 failures
    }
    finally
    {
        // Finally will always be executed, even if there is a return/break/continue statement in the try or catch block
        totalCounter++;
    }
}

Console.WriteLine("Counter: " + counter);
Console.WriteLine("Success: " + successCounter);
Console.WriteLine("Failure: " + failureCounter);
Console.WriteLine("Total: " + totalCounter);

void UnreliableIncrementor()
{
    // 50% chance of failure
    if (Random.Shared.Next(0, 2) == 0)
    {
        throw new Exception("This method sometimes fails");
    }
    else
    {
        counter++;
    }
}