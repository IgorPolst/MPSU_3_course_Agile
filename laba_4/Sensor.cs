class Sensor
{
    private static int _counter = 0;
    private string Id = _counter.ToString();
    private bool Active;

    public string _id
    {
        get => Id;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Id не может быть пустым");
            Id = value;
        }
    }

    public bool _active
    {
        get => Active;
        set => Active = value;
    }

    public Sensor()
    {
        _counter++;
        _id = _counter.ToString();
    }

    public virtual double Read()
    {
        if (_active)
            return 0.0;
        return double.NaN;
    }

    public void Activate()
    {
        _active = true;
    }

    public void Deactivate()
    {
        _active = false;
    }

    public string Info()
    {
        return $"ID:{_id} Status:{_active}";
    }
}