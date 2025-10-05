namespace laba_5;

public class WeatherAgregator : ISensor, IController
{
    public string Id { get; set; }
    public double LastMeasurement { get; set; }
    public string Name { get; set; }
    public int Load { get; set; }
    private IActuator target;
    private List<double> measurement = new List<double>();

    public WeatherAgregator(string id, string name, IActuator target)
    {
        Id = id;
        Name = name;
        Load = 0;
        LastMeasurement = 0;
        this.target = target;
    }

    public void Report(IController controller)    
    {
        if (controller == null)
            throw new ArgumentNullException(nameof(controller));
        controller.Route(this, target);
    }

    public void Route(ISensor sensor, IActuator target)
    {
        Load++;
        measurement.Add(sensor.LastMeasurement);
        LastMeasurement = ComputeAverage();

        if (target != null!)
            if (LastMeasurement > 20)
                target.ReceiveCommand(this, "On");
            else
                target.ReceiveCommand(this, "Off");
    }

    private double ComputeAverage()
    {
        double sum = 0;
        foreach (var m in measurement) sum += m;
        return sum / measurement.Count;
    }


}