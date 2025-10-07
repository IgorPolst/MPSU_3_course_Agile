namespace laba_5D;

public class PlainNotification : INotification
{
    private string message = string.Empty;
    private bool sent;

    public string Message
    {
        get => message;
        set => message = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool Sent
    {
        get => sent;
        set => sent = value;
    }

    public PlainNotification(string message)
    {
        Message = message;
        Sent = false;
    }
    
    public void Send()
    {
        Console.WriteLine($"Отправка уведомления: {Message}");
        Sent = true;
        Console.WriteLine("✅ Уведомление успешно отправлено!");
    }

}
