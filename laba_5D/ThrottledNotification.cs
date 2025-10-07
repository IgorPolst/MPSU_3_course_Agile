namespace laba_5D;

public class ThrottledNotification : INotification, IRateLimited
{
    private int usedInCurrentMinute;
    private string message = string.Empty;
    private bool sent;
    private int perMinuteLimit;
    private DateTime lastResetTime;


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

    public int PerMinuteLimit
    {
        get => perMinuteLimit;
        set => perMinuteLimit = Math.Max(1, value);
    }

    public int UsedInCurrentMinute => usedInCurrentMinute;

    public ThrottledNotification(string message, int perMinuteLimit)
    {
        Message = message;
        PerMinuteLimit = perMinuteLimit;
        usedInCurrentMinute = 0;
        lastResetTime = DateTime.Now;
    }

    public void Send()
    {
        ResetWindowIfNeeded();

        if (TryConsume())
        {
            Console.WriteLine($"📨 Попытка отправки уведомления: {Message}");
            Sent = true;
            Console.WriteLine("✅ Уведомление успешно отправлено!");
        }
        else
        {
            Console.WriteLine($"⏳ Уведомление не отправлено: {Message}");
            Console.WriteLine($"   Лимит превышен! Использовано {usedInCurrentMinute}/{PerMinuteLimit} в текущей минуте");
            Sent = false;
        }

    }

    public bool TryConsume()
    {
        ResetWindowIfNeeded();

        if (usedInCurrentMinute < PerMinuteLimit)
        {
            usedInCurrentMinute++;
            return true;
        }

        return false;
    }

    private void ResetWindowIfNeeded()
    {
        var currentTime = DateTime.Now;
        if (currentTime.Minute != lastResetTime.Minute || currentTime.Hour != lastResetTime.Hour)
            ResetWindow();

    }
    public void ResetWindow()
    {
        usedInCurrentMinute = 0;
        lastResetTime = DateTime.Now;
        Console.WriteLine("🔄 Окно лимита сброшено!");
    }

}

