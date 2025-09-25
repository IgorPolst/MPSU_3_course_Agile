class Thermometer : Sensor
{
    private double Celsius;

    public double _celsius
    {
        get => Celsius;
        set
        {
            if (value < -273.15)
                throw new ArgumentOutOfRangeException(nameof(value), "Температура не может быть ниже абсолютного нуля (-273.15°C)");
            Celsius = value;
        }
    }

    public Thermometer(double celsius) : base()
    {
        _celsius = celsius;
    }
    public void SetCelsius(double celsius)
    {
        _celsius = celsius;
    }
    public override double Read()
    {
        return _celsius;
    }
}