namespace laba_5;
public interface ISensor
{
    string Id { get; }
    double LastMeasurement { get;}

    public void Report(IController controller);
    
}