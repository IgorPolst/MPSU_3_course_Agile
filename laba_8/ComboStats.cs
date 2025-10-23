namespace laba_8;

using static Messages;
public class ComboStats
{
    private int largePickupsCount;
    private int previousScore;

    public ComboStats(ScoreMonitor monitor)
    {
        monitor.ScoreChanged += OnScoreChanged;
        previousScore = 0;
        largePickupsCount = 0;
    }

    private void OnScoreChanged(ScoreMonitor sender, int score)
    {
        int pointsGained = score - previousScore;
        if (pointsGained >= 30)
        {
            largePickupsCount++;
        }

        previousScore = score;
    }

    public void Report()
    {
        Console.WriteLine(LargePickupsReport, largePickupsCount);
    }
}