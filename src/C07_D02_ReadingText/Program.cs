// If the directory does not exist, create it
// NOTE: We inlined the variable
if (!Directory.Exists("C:\\temp"))
{
    Directory.CreateDirectory("C:\\temp");
}


AskQuestionAndStoreAnswer("What is your name?");
AskQuestionAndStoreAnswer("How old are you?");
AskQuestionAndStoreAnswer("Were are you right now?");


// Read the file and print it to the screen
var allText = File.ReadAllText(@"C:\temp\answer.txt");
Console.WriteLine("================ START OF FILE CONTENT ================");
Console.WriteLine(allText);
Console.WriteLine("================= END OF FILE CONTENT =================");

Console.WriteLine("Please press enter to quit the application");
Console.ReadLine();


void AskQuestionAndStoreAnswer(string question)
{
    Console.Write($"{question} ");
    string answer = Console.ReadLine();
    
    File.AppendAllText(@"C:\temp\answer.txt", $"Question: {question}");
    File.AppendAllText(@"C:\temp\answer.txt", $"\n");
    File.AppendAllText(@"C:\temp\answer.txt", $"Answer: {answer}");
    File.AppendAllText(@"C:\temp\answer.txt", $"\n");
    File.AppendAllText(@"C:\temp\answer.txt", $"\n");
}