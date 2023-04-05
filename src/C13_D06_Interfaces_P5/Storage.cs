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