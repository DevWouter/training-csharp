Dictionary<string, string> quizQuestions = new Dictionary<string, string>();
List<string> answeredQuestions = new List<string>();

quizQuestions.Add("Geography: What is the capital of France?", "Paris");
quizQuestions.Add("Math: What is 2 + 2?", "4");
quizQuestions.Add("History: In what year was Windows 95 released?", "1995");
quizQuestions.Add("History: In what year was Windows XP released?", "2001");
quizQuestions.Add("History: In what year was Windows 1.01 released?", "1985");
quizQuestions.Add("Geography: What is the capital of Germany?", "Berlin");
quizQuestions.Add("Geography: What is the capital of Spain?", "Madrid");
quizQuestions.Add("Math: What is 9 / 3?", "3");
quizQuestions.Add("Math: What is a good number under a birthday?", "pi"); // Because pie is good

string[] categories = new[] { "Math", "Geography", "History" };
HashSet<string> completedCategories = new HashSet<string>();


Console.WriteLine("Welcome to the quiz!");
foreach (var category in ChooseCategory())
{
    Console.WriteLine($"Questions in category {category}:");

    foreach (var mathQuestions in GetQuestionsIn(category))
    {
        Console.WriteLine(mathQuestions.Key);
        var answer = Console.ReadLine();
        if (answer != mathQuestions.Value)
        {
            Console.WriteLine("Incorrect! The answer was " + mathQuestions.Value);
            break; // Stop the quiz
        }

        Console.WriteLine("Correct!");
        answeredQuestions.Add(mathQuestions.Key);
    }
}

if (answeredQuestions.Count == quizQuestions.Count)
{
    Console.WriteLine("You answered all questions correctly!");
}
else
{
    Console.WriteLine("You answered {0} questions correctly out of {1}", answeredQuestions.Count, quizQuestions.Count);
}


IEnumerable<string> ChooseCategory()
{
    while (true)
    {
        if(categories.Length == completedCategories.Count)
        {
            Console.WriteLine("You have completed all categories");
            yield break;
        }
        
        Console.WriteLine("Please choose a category:");
        foreach (var category in categories)
        {
            if (completedCategories.Contains(category)) continue;
            Console.WriteLine($"- {category}");
        }

        Console.Write("Which category do you want to choose? ");
        
        var answer = Console.ReadLine();
        if (completedCategories.Contains(answer))
        {
            Console.WriteLine("You have already completed this category");
            continue;
        }

        if (!categories.Contains(answer))
        {
            Console.WriteLine("That is not a valid category");
            continue;
        }

        completedCategories.Add(answer);
        yield return answer;
    }
}


IEnumerable<KeyValuePair<string, string>> GetQuestionsIn(string category)
{
    foreach (var question in quizQuestions)
    {
        if (answeredQuestions.Contains(question.Key))
        {
            continue;
        }

        if (question.Key.StartsWith(category))
        {
            yield return question;
        }
    }
}