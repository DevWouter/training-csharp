// ┌ Variable type (bool)
// │   ┌ Variable name
// │   │                    ┌ Assign
// │   │                    │ ┌ Negate operator (inverts the value of the expression)
// │   │                    │ │┌ Directory (a type)
// │   │                    │ ││        ┌ The "." indicates that we want a member of the type
// │   │                    │ ││        │┌ Method "Exists"
// │   │                    │ ││        ││      ┌ Argument (a string literal)
bool isTempDirectoryMissing = !Directory.Exists("C:\\temp");

if (isTempDirectoryMissing)
{
    Directory.CreateDirectory("C:\\temp");
}

AskQuestionAndStoreAnswer("What is your name?");
AskQuestionAndStoreAnswer("How old are you?");
AskQuestionAndStoreAnswer("Were are you right now?");

void AskQuestionAndStoreAnswer(string question)
{
    Console.Write($"{question} ");
    string answer = Console.ReadLine();
    File.
    File.AppendAllText(@"C:\temp\answer.txt", $"Question: {question}");
    File.AppendAllText(@"C:\temp\answer.txt", $"\n");
    File.AppendAllText(@"C:\temp\answer.txt", $"Answer: {answer}");
    File.AppendAllText(@"C:\temp\answer.txt", $"\n");
    File.AppendAllText(@"C:\temp\answer.txt", $"\n");
}