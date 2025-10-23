namespace laba_8;
class Program
{
    static void Main(string[] args)
    {
        ScoreMonitor monitor = new ScoreMonitor();
        ConsoleAnnouncer announcer = new ConsoleAnnouncer(monitor);
        ComboStats stats = new ComboStats(monitor);

        monitor.Start();
        announcer.UnsubscribeFromMilestone(monitor);

        stats.Report();

    }
}