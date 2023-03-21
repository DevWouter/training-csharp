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