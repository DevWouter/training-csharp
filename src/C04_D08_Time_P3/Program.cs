DateTime current = DateTime.Now; // Now = Local Time
DateTime currentUtc = DateTime.UtcNow; // UTC = Coordinated Universal Time

Console.WriteLine("DateTime.Now:               " + current);
Console.WriteLine("DateTime.UtcNow:            " + currentUtc);

Console.WriteLine("DateTime.Now.Kind:          " + current.Kind);
Console.WriteLine("DateTime.UtcNow.Kind:       " + currentUtc.Kind);
