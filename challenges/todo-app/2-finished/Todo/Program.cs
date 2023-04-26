if (args.Any())
{
    // Remove executable if called from external path
    if (args[0].EndsWith(".dll") || args[0].EndsWith(".exe"))
    {
        args = args.Skip(1).ToArray();
    }
}

Console.WriteLine("App was launched with the following arguments:");
foreach (var arg in args)
{
    Console.WriteLine(arg);
}

string[] lines = File.ReadAllLines("tasks.txt");

if (args[0] == "list")
{
    if (args[1] == "todo" || args[1] == "all")
    {
        int count = lines.Count(line => line[1] == ' ');
        Console.WriteLine($"{count} tasks todo");
        foreach (string line in lines.Where(line => line[1] == ' '))
        {
            Console.WriteLine(line);
        }
    }

    if (args[1] == "done" || args[1] == "all")
    {
        int count = lines.Count(line => line[1] == 'x');
        Console.WriteLine($"{count} tasks done");
        foreach (string line in lines.Where(line => line[1] == 'x'))
        {
            Console.WriteLine(line);
        }
    }
}

if (args[0] == "add")
{
    string task = args[1];
    File.AppendAllText("tasks.txt", "\n[ ] " + task);
    Console.WriteLine("Task has been added");
}

if (args[0] == "done")
{
    List<string> tasks  = File.ReadAllLines("tasks.txt").ToList();
    tasks.Remove("[ ] " + args[1]);
    tasks.Add($"[x] {args[1]}");
    Console.WriteLine("Task has been marked as completed");
    File.WriteAllLines("tasks.txt", tasks);
}

if (args[0] == "undo")
{
    List<string> tasks  = File.ReadAllLines("tasks.txt").ToList();
    tasks.Remove("[x] " + args[1]);
    tasks.Add($"[ ] {args[1]}");
    Console.WriteLine("Task has been marked as incomplete");
    File.WriteAllLines("tasks.txt", tasks);
}

if (args[0] == "archive")
{
    List<string> tasks  = File.ReadAllLines("tasks.txt").ToList();
    IEnumerable<string> tasksToRemove = tasks.Where(x => x[1] == 'x').ToList();
    foreach (var task in tasksToRemove)
    {
        tasks.Remove(task);
    }   
    
    Console.WriteLine($"Archived {tasksToRemove.Count()} tasks");
    File.WriteAllLines("tasks.txt", tasks);
}


if (args[0] == "clear")
{
    List<string> tasks  = File.ReadAllLines("tasks.txt").ToList();
    tasks.Clear();
    File.WriteAllLines("tasks.txt", tasks);
    Console.WriteLine("Cleared your task list");
}