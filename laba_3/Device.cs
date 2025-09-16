namespace laba_3;

class Device
{
    public string Brand { get; init; }
    public float BatteryCapacity { get; init; }

    public Device(string brand, float batteryCapacity)
    {
        Brand = brand;
        BatteryCapacity = batteryCapacity;
    }

    public virtual string ShowDeviceInfo()
    {
        return $"Марка устройства: {Brand}\nЁмкость батареии: {BatteryCapacity}\n";
    }
}