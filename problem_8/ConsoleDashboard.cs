namespace problem_8;

public class ConsoleDashboard
{
    private const string LoadMessageFormat = "CPU: {0}%";
    private const string OverloadMessageFormat = "Перегрузка CPU: {0}% — сократите нагрузку";
    private const string TemperatureWarningMessage = "Внимание! Температура CPU: {0} - перегрев!";
    public ConsoleDashboard(CpuMonitor cpuMonitor)
    {
        cpuMonitor.LoadChanged += LoadChangedHandler;
        cpuMonitor.OverloadReached += OverloadReachedHandler;
        cpuMonitor.TemperatureChanged += TemperatureChangedHandler;
    }

    private void LoadChangedHandler(CpuMonitor monitor, int percent) =>
        Console.WriteLine(LoadMessageFormat, monitor.Load);

    private void OverloadReachedHandler(object? sender, int percent) =>
        Console.WriteLine(OverloadMessageFormat, percent);
        
    
    private void TemperatureChangedHandler(CpuMonitor monitor, int percent) =>
        Console.WriteLine(TemperatureWarningMessage, monitor.Temperature);

}
