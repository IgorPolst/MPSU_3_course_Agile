using System.Runtime.InteropServices.Marshalling;

class Hygrometer : Sensor
{
    private double Humidity;

    public double _humidity
    {
        get => Humidity;
        private set => Humidity = CheckHumidity(value);
    }

    public Hygrometer(double humidity) : base()
    {
        _humidity = humidity;
    }

    public void SetHumidity(double h)
    {
        _humidity = h;
    }

    protected static double CheckHumidity(double h)
    {
        if (h <= 0 || h >= 100)
            throw new ArgumentOutOfRangeException(nameof(h), "Значение должно быть от 0 до 100");
        else
            return h;
    }

}