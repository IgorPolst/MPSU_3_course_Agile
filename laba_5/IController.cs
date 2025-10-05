namespace laba_5;
public interface IController
{
    string Name { get; set; }
    int Load { get; set; }
    void Route(ISensor sensor, IActuator target);
}