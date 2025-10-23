namespace laba_8;

using static Messages;
public class ConsoleAnnouncer
{
    public ConsoleAnnouncer(ScoreMonitor monitor)
    {
        monitor.ScoreChanged += ScoreChangedHandler;
        monitor.MilestoneReached += OnMilestoneReached;
    }

    private void ScoreChangedHandler(ScoreMonitor sender, int score)
    {
        Console.WriteLine(ScoreChanged, score);
    }

    private void OnMilestoneReached(object? sender, int milestone)
    {
        Console.WriteLine(MilestoneReached, milestone);
    }

    public void UnsubscribeFromMilestone(ScoreMonitor monitor)
    {
        monitor.MilestoneReached -= OnMilestoneReached;
    }
}