// We are a game developer writing a game.
// We don't exactly know how we are going to save the high scores yet, but we know that we need to save a list of high scores.

InMemoryStorage inMemoryStorage = new InMemoryStorage();
OnDiskStorage onDiskStorage = new OnDiskStorage();

IHighScoreSaver saver;
IHighScoreLoader loader;

loader = inMemoryStorage;
saver = inMemoryStorage;

// Or we can store it on disk...
// saver = onDiskStorage;
// loader = onDiskStorage;


// NOTE: This part of the code has been unchanged
// --------------------------- >8 --------------------------------
var game = new Game(saver, loader);

game.AddHighScore(new HighScore("Wouter", 4000));
game.AddHighScore(new HighScore("Rutger", 3000));
game.AddHighScore(new HighScore("Jan", 2000));
game.AddHighScore(new HighScore("Joke", 1000));

Console.WriteLine("Highscore");
Console.WriteLine("---------");
foreach (var highScore in loader.Load())
{
    Console.WriteLine($"- {highScore.Name} - {highScore.Score}");
}
// --------------------------- >8 --------------------------------


public class InMemoryStorage : IHighScoreSaver, IHighScoreLoader
{
    private List<HighScore> _highScores = new List<HighScore>();
    public void Save(List<HighScore> highScore) => _highScores = highScore;
    public List<HighScore> Load() => _highScores;
}

// New class
public class OnDiskStorage : IHighScoreSaver, IHighScoreLoader
{
    public void Save(List<HighScore> highScore)
    {
        var lines = new List<string>();
        foreach (var score in highScore)
        {
            lines.Add($"{score.Name};{score.Score}");
        }

        File.WriteAllLines("highscores.txt", lines);
    }

    public List<HighScore> Load()
    {
        if (!File.Exists("highscores.txt")) return new List<HighScore>();

        var highScores = new List<HighScore>();
        var lines = File.ReadLines("highscores.txt");
        foreach (var line in lines)
        {
            var splitLines = line.Split(";");
            var highScore = new HighScore(splitLines[0], int.Parse(splitLines[1]));
            highScores.Add(highScore);
        }

        return highScores;
    }
}