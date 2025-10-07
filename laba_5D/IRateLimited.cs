namespace laba_5D;

public interface IRateLimited
{
    int PerMinuteLimit {get; }
    bool TryConsume();
}
