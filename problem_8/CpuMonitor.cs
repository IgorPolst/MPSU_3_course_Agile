namespace problem_8;

public delegate void CpuEventHandler(CpuMonitor cpuMonitor, int percent);

public class CpuMonitor
{
    private const string ValueErrorMessage = "Значение не может быть < 0";
    private const string CpuBurnoutMessage ="Ваш CPU сгорел!";
    private const int TemperatureStep = 5;
    private const int LoadLimit = 85;
    private const float TemperatureLimitPerсent = 0.6f;

    private int load;
    private int temperature;
    private int maxTemperature;
    private EventHandler<int>? overloadReached;

    public event CpuEventHandler? LoadChanged;
    public event CpuEventHandler? TemperatureChanged;
    public event EventHandler<int>? OverloadReached
    {
        add { overloadReached += value; }
        remove { overloadReached -= value; }
    }

    public int Load
    {
        get => load;
        set => load = Math.Max(value, 0);
    }
    public int Temperature
    {
        get => temperature;
        set => temperature = Math.Max(value, 0);
    }
    public int MaxTemperature
    {
        get => maxTemperature;
        init
        {
            if (value <= 0 || value <= temperature)
                throw new ArgumentException(ValueErrorMessage);
            maxTemperature = value;
        }
    }

    public CpuMonitor(){ }
    public CpuMonitor(int load, int temperature, int maxTemperature = 0)
    {
        Load = load;
        Temperature = temperature;
        MaxTemperature = maxTemperature;
    } 

    public void Start()
    {
        Random random = new Random();
        int countGeneration = random.Next(10, 21);
        for (int i = 0; i < countGeneration; i++)
        {
            int newLoad = random.Next(-100, 100);
            Load = Math.Min(Load + newLoad, 100);
            OnLoadChanged();
            CheckOverloadReached();

        }
    }

    private void CheckOverloadReached()
    {
        if (Load >= LoadLimit) 
        {
            OnOverloadReached();
            CheckTemperature();
        }
    }
    private void CheckTemperature()
    {
        int newTemperature = Temperature + TemperatureStep;
        if (newTemperature >= MaxTemperature)
        {
            Console.WriteLine(CpuBurnoutMessage);
            Environment.Exit(0);
        }
        else if (newTemperature > MaxTemperature * TemperatureLimitPerсent)
        {
            OnTemperatureChanged();
            Temperature = Math.Min(newTemperature, MaxTemperature);
        }
    }
    

    private void OnTemperatureChanged() =>
        TemperatureChanged?.Invoke(this, temperature);
    private void OnLoadChanged() =>
        LoadChanged?.Invoke(this, load);
    private void OnOverloadReached() =>
        overloadReached?.Invoke(this, load);


}