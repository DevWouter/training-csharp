string[] categories = new[] { "Math", "Geography", "History" };
HashSet<string> completedCategories = new HashSet<string>();


Console.WriteLine("Welcome to the quiz!");
foreach (var category in ChooseCategory())
{
    Console.WriteLine($"Questions in category {category}:");
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
