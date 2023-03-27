// NOTE: Please run C07_D04_CopyFiles before running this example

string tempBackupPath = "C:\\temp\\backup";

// Deleting the files
string[] files = Directory.GetFiles(tempBackupPath);
for (int i = 0; i < files.Length; ++i)
{
    File.Delete(files[i]);
}

// Deleting the directory
Directory.Delete(tempBackupPath);