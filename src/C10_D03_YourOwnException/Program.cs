int counter = 0;
int successCounter = 0;
int failureCounter = 0;
int totalCounter = 0;

void Loop(int attempts, int maxAllowedFailures)
{
    for (var i = 0; i < attempts; ++i)
    {
        try
        {
            UnreliableIncrementor();
            successCounter++;
        }
        catch
        {
            failureCounter++;
            if (failureCounter > maxAllowedFailures)
            {
                throw new TooManyErrorsException("Too many errors", failureCounter);
            }
        }
        finally
        {
            // Finally will always be executed, even if there is a return/break/continue statement in the try or catch block
            totalCounter++;
        }
    }

}

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


// TODO: Move this to another chapter called "Custom Exceptions" or "Improved Exceptions", needs to be after inheritance
public class TooManyErrorsException : Exception
{
    public int ErrorCount { get; set; }
    
    public TooManyErrorsException(string message, int errorCount) : base(message)
    {
        ErrorCount = errorCount;
    }

    public TooManyErrorsException(string message, int errorCount, Exception inner) : base(message, inner)
    {
        ErrorCount = errorCount;
    }
}