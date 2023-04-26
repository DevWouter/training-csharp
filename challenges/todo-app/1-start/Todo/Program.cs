if (args.Any())
{
    // Remove executable if called from external path
    if (args[0].EndsWith(".dll") || args[0].EndsWith(".exe"))
    {
        args = args.Skip(1).ToArray();
    }
}

// Console.WriteLine("App was launched with the following arguments:");
// foreach (var arg in args)
// {
//     Console.WriteLine(arg);
// }