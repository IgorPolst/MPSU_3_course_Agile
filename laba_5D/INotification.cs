namespace laba_5D;

public interface INotification
{
    string Message{ get; }
    bool Sent { get; }
    public void Send();
}
