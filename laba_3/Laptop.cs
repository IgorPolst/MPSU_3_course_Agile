namespace laba_3;


class Laptop : Device
{
    public double ProcessorPerformance { get; init; }

    public Laptop(string brand, float batteryCapacity, double processorPerformance)
        : base(brand, batteryCapacity)
    {
        ProcessorPerformance = processorPerformance;
    }

    public override string ShowDeviceInfo()
    {
        return base.ShowDeviceInfo()
            + $"Производительность процессора: {ProcessorPerformance}\n";
    }
}