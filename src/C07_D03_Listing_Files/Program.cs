// NOTE: When the body of an `if` or `for` statement is a single statement we can omit the curly braces.
if(!Directory.Exists("C:\\temp"))
    Directory.CreateDirectory("C:\\temp");

// Creating 10 files
for (int i = 0; i < 10; ++i)
{
    File.WriteAllText($"C:\\temp\\test_{i}.txt", $"This is file number {i}");
}

string[] files = Directory.GetFiles("C:\\temp");

for(int i = 0; i < files.Length; ++i)
{
    Console.WriteLine($"File {i}: {files[i]}");
}

