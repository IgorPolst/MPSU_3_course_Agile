namespace problem_8;

class Program
{
    static void Main(string[] args)
    {
        DemoCpuMonitor(load: 30, temperature: 40, maxTemperature: 100);
        DemoCpuMonitor(load: 80, temperature: 60, maxTemperature: 100);
        DemoCpuMonitor(load: 50, temperature: 90, maxTemperature: 100);
    }

    static void DemoCpuMonitor(int load, int temperature, int maxTemperature)
    {        
        try
        {
            var cpuMonitor = new CpuMonitor(load, temperature, maxTemperature);
            var dashboard = new ConsoleDashboard(cpuMonitor);
            var stats = new OverloadStats(cpuMonitor);

            cpuMonitor.Start();
            
            stats.Report();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании монитора: {ex.Message}");
        }
    }
}