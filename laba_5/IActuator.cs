namespace laba_5
{
    public interface IActuator
    {
        string Id { get; }
        bool IsOn { get; }
        void ReceiveCommand(IController controller, string command);
    }
}