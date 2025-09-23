namespace laba_3;

class Smartphone : Device
{
    public string ScreenResolution { get; init; }

    public Smartphone(string brand, float batteryCapacity, string screenResolution)
        : base(brand, batteryCapacity)
    {
        ScreenResolution = screenResolution;
    }

    public override string ShowDeviceInfo()
    {
        return base.ShowDeviceInfo() + $"Разрешение экрана: {ScreenResolution}\n";
    }
}