// We are a game developer writing a game.
// We don't exactly know how we are going to save the high scores yet, but we know that we need to save a list of high scores.

InMemoryStorage inMemoryStorage = new InMemoryStorage();
OnDiskStorage onDiskStorage = new OnDiskStorage();
HybridStorage hybridStorage = new HybridStorage(inMemoryStorage, inMemoryStorage, onDiskStorage, onDiskStorage);

IHighScoreSaver saver;
IHighScoreLoader loader;

loader = hybridStorage;
saver = hybridStorage;

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

public class HybridStorage : IHighScoreSaver, IHighScoreLoader
{
    private IHighScoreSaver _shortTermSaver;
    private IHighScoreLoader _shortTermLoader;
    private IHighScoreSaver _longTermSaver;

    public HybridStorage(
        IHighScoreSaver shortTermSaver,
        IHighScoreLoader shortTermLoader,
        IHighScoreSaver longTermSaver,
        IHighScoreLoader longTermLoader)
    {
        // Update the short term storage with the long term storage
        // But... should we do that here? How often is hybrid storage created?
        var current = longTermLoader.Load();
        shortTermSaver.Save(current);

        _shortTermSaver = shortTermSaver;
        _shortTermLoader = shortTermLoader;
        _longTermSaver = longTermSaver;
    }

    public void Save(List<HighScore> highScore)
    {
        _shortTermSaver.Save(highScore);
        _longTermSaver.Save(highScore);
    }

    public List<HighScore> Load()
    {
        return _shortTermLoader.Load();
    }
}

// 65 lines of code