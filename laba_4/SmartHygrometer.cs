class SmartHygrometer : Hygrometer
{
    private double Calibration;

    public double _calibration
    {
        get => Calibration;
        private set => Calibration = CheckCalibration(value);
    }

    public SmartHygrometer(double humidity, double calibration) : base(humidity)
    {
        _calibration = CheckCalibration(calibration);
    }

    public override double Read()
    {
        return _calibration + _humidity;
    }

    private double CheckCalibration(double delta)
    {
        if (delta <= -10 || delta >= 10)
            throw new ArgumentOutOfRangeException(nameof(delta), "Значение должно быть от -10 до 10");
        else if (delta + _humidity <= 0 || delta + _humidity >= 100)
            throw new ArgumentOutOfRangeException(nameof(delta), "Значение должно быть от 0 до 100");
        else
            return delta;
    }
}