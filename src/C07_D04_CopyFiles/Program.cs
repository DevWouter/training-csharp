string tempPath = "C:\\temp";
string tempBackupPath = "C:\\temp\\backup";

// NOTE: When the body of an `if` or `for` statement is a single statement we can omit the curly braces.
// NOTE: Putting the body of the `for` statement on a new line is not required, but does make it easier to read.
if (!Directory.Exists(tempPath))
    Directory.CreateDirectory(tempPath);

for (int i = 0; i < 10; ++i)
{
    File.WriteAllText($"{tempPath}\\test_{i}.txt", $"This is file number {i}");
}

// Create a backup directory
if (!Directory.Exists(tempBackupPath))
{
    Directory.CreateDirectory(tempBackupPath);
}

// Copy all files from the temp directory to the backup directory
string[] files = Directory.GetFiles(tempPath);
for (int i = 0; i < files.Length; ++i)
{
    string filename = files[i];
    string filenameWithoutPath = Path.GetFileName(filename);
    string destinationFilename = $"{tempBackupPath}\\{filenameWithoutPath}";
    File.Copy(filename, destinationFilename);
    Console.WriteLine($"Copied \"{filename}\" to \"{destinationFilename}\"");
}