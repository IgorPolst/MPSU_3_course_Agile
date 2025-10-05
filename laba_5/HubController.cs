namespace laba_5;

public class HubController : IActuator, IController
{
    public string Name { get; set; }
    public int Load { get; set; }
    public string Id { get; set; }
    public bool IsOn { get; set; }
    public string LastCommand { get; set; } = string.Empty;

    private double threshold;

    public HubController(string name, string id, double threshold)
    {
        Name = name;
        Id = id;
        Load = 0;
        IsOn = false;
        this.threshold = threshold;
    }

    public void Route(ISensor sensor, IActuator target)
    {
        Load++;
        if (sensor.LastMeasurement > threshold)
            target.ReceiveCommand(this, "On");
        else
            target.ReceiveCommand(this, "Off");
    }

    public void ReceiveCommand(IController controller, string command)
    {
        LastCommand = command;
        if (command == "On") IsOn = true;
        if (command == "Off") IsOn = false;
        Console.WriteLine($"{Id}: принял команду {command} от {controller.Name}");
    }

}