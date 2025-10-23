namespace problem_8;

public class OverloadStats
{
    private const string ReportMessage = "Загрузка ≥ 70% встречалась {0} раз";
    private const int OverloadThreshold = 70;
    private int countOverloads;

    public int CountOverloads
    {
        get => countOverloads;   
    }
    public OverloadStats(CpuMonitor cpuMonitor)
    {
        cpuMonitor.LoadChanged += LoadChangeHandler;
    }

    public void LoadChangeHandler(CpuMonitor cpuMonitor, int percent)
    {
        if (cpuMonitor.Load >= OverloadThreshold)
        {
            countOverloads++;
        }
    }

    public void Report()
    {
        Console.WriteLine(ReportMessage, CountOverloads);
    }
}