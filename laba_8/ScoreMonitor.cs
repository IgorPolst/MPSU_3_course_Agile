namespace laba_8;

using static Messages;
public delegate void ScoreEventHandler(ScoreMonitor sender, int score);

public class ScoreMonitor
{
    public event ScoreEventHandler? ScoreChanged;
    private EventHandler<int>? milestoneReached;
    
    public event EventHandler<int> MilestoneReached
    {
        add
        {
            milestoneReached += value;
            Console.WriteLine(SubscriberAdded);
        }
        remove
        {
            milestoneReached -= value;
            Console.WriteLine(SubscriberRemoved);
        }
    }
    
    private int totalScore;
    
    public ScoreMonitor()
    {
        totalScore = 0;
    }
    
    public void Start()
    {
        Random random = new Random();
        int numberOfPickups = random.Next(10, 15);
        Console.WriteLine(string.Format(StartSeries, numberOfPickups));
        
        for (int i = 0; i < numberOfPickups; i++)
        {
            int points = random.Next(5, 51);
            int oldScore = totalScore;
            totalScore += points;
            
            OnScoreChanged();
            CheckMilestones(oldScore, totalScore);
        }
        
        Console.WriteLine(string.Format(FinalScore, totalScore));
    }
    
    protected virtual void OnScoreChanged()
    {
        ScoreChanged?.Invoke(this, totalScore);
    }
    
    private void CheckMilestones(int oldScore, int newScore)
    {
        int oldHundreds = oldScore / 100;
        int newHundreds = newScore / 100;
        
        if (newHundreds > oldHundreds)
        {
            for (int milestone = (oldHundreds + 1) * 100;
            milestone <= newHundreds * 100;
            milestone += 100)
            {
                OnMilestoneReached(milestone);
            }
        }
    }
    
    protected virtual void OnMilestoneReached(int milestone)
    {
        milestoneReached?.Invoke(this, milestone);
    }
}