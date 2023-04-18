// See https://aka.ms/new-console-template for more information

void DepthFirstSearch(string rootFolder)
{
    Console.CursorVisible = false;
    var queue = new Queue<string>(GetDirectories(rootFolder));
    string longestPath = string.Empty;
    int foundAt = 0;
    int stepCounter = 0;
    while (queue.Count > 0)
    {
        var folder = queue.Dequeue();

        if (folder.Length > longestPath.Length)
        {
            longestPath = folder;
            foundAt = stepCounter;
        }

        var subFolders = GetDirectories(folder);
        foreach (var subFolder in subFolders)
        {
            queue.Enqueue(subFolder);
        }
        
        Console.SetCursorPosition(0, 0);
        DumpProgress(stepCounter, queue.Count, folder);
        stepCounter++;
    }

    Console.WriteLine($"Longest path: {longestPath}");
    Console.WriteLine($"Found at step: {foundAt}");
}

void DumpProgress(int step, int queuedSteps, string currentFolder)
{
    var stepStr = $"Step {step}, queued: {queuedSteps}";
    var paddingStepStr = new string(' ', Math.Max(0, Console.BufferWidth - stepStr.Length));
    Console.Write(stepStr + paddingStepStr);
    var folderStr = $"Current folder: {currentFolder}";
    var paddingFolderStr = new string(' ', Math.Max(0, Console.BufferWidth - folderStr.Length));
    Console.WriteLine(folderStr + paddingFolderStr);
}

string[] GetDirectories(string s)
{
    return Directory.GetDirectories(s, "*", new EnumerationOptions() { IgnoreInaccessible = true });
}


void BreadthFirstSearch(string rootFolder)
{
    Console.CursorVisible = false;
    var stack = new Stack<string>(GetDirectories(rootFolder));
    int stepCounter = 0;
    string longestPath = string.Empty;
    int foundAtStep = 0;
    while (stack.Count > 0)
    {
        var folder = stack.Pop();

        if (folder.Length > longestPath.Length)
        {
            longestPath = folder;
            foundAtStep = stepCounter;
        }

        var subFolders = GetDirectories(folder);
        foreach (var subFolder in subFolders)
        {
            stack.Push(subFolder);
        }

        Console.SetCursorPosition(0, 8);
        DumpProgress(stepCounter, stack.Count, folder);
        stepCounter++;
    }

    Console.WriteLine($"Longest path: {longestPath}");
    Console.WriteLine($"Found at step: {foundAtStep}");
}

DepthFirstSearch(@"C:\");
BreadthFirstSearch(@"C:\");