// We are a game developer writing a game.
// We don't exactly know how we are going to save the high scores yet, but we know that we need to save a list of high scores.

InMemoryStorage inMemoryStorage = new InMemoryStorage();
OnDiskStorage onDiskStorage = new OnDiskStorage();
HybridSaver hybridSaver = new HybridSaver(new List<IHighScoreSaver> { inMemoryStorage, onDiskStorage });

IHighScoreSaver saver;
IHighScoreLoader loader;

loader = inMemoryStorage; // We always want to load from the in-memory storage
saver = hybridSaver; // But we save the high scores to both the in-memory storage and the on-disk storage

// Syncing the in-memory storage with the on-disk storage
inMemoryStorage.Save(onDiskStorage.Load());

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

public class HybridSaver : IHighScoreSaver
{
    private List<IHighScoreSaver> _savers;
    public HybridSaver(List<IHighScoreSaver> savers) => _savers = savers;
    public void Save(List<HighScore> highScore) => _savers.ForEach(s => s.Save(highScore));
}

// 41 lines of code (65-41 = 24 lines of code saved)