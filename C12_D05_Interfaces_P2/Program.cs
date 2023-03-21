// We are a game developer writing a game.
// We don't exactly know how we are going to save the high scores yet, but we know that we need to save a list of high scores.

InMemoryStorage inMemoryStorage = new InMemoryStorage();
IHighScoreSaver saver = inMemoryStorage;
IHighScoreLoader loader = inMemoryStorage;

// NOTE: This part of the code will never change
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

// NOTE: In the examples here after the Game, IHighScoreSaver and IHighScoreLoader won't change, so we will move it to another file.
public interface IHighScoreSaver
{
    void Save(List<HighScore> highScore);
}

public interface IHighScoreLoader
{
    List<HighScore> Load();
}

public class Game
{
    private IHighScoreSaver _highScoreSaver;
    private IHighScoreLoader _highScoreLoader;

    public Game(IHighScoreSaver highScoreSaver, IHighScoreLoader highScoreLoader)
    {
        _highScoreSaver = highScoreSaver;
        _highScoreLoader = highScoreLoader;
    }

    public void AddHighScore(HighScore highScore)
    {
        var highScores = _highScoreLoader.Load().ToList();
        highScores.Add(highScore);
        _highScoreSaver.Save(highScores);
    }
}

public class HighScore
{
    public string Name { get; set; }
    public int Score { get; set; }

    public HighScore()
    {
    }

    public HighScore(string name, int score)
    {
        Name = name;
        Score = score;
    }
}