
namespace laba_6_v2;

using static Messages.ContextMessages;
public class MovmentContext
{
    private bool hasForestWalker { get; set; }
    private bool isRaining { get; set; }
    private bool isMountainBreed { get; set; }

    public bool HasForestWalker
    {
        get => hasForestWalker;
        set
        {
            NotifyForestChange(value);
            hasForestWalker = value;
        }
    }

    public bool IsRaining
    {
        get => isRaining;
        set
        {
            ToggleRain(value);
            isRaining = value;
        }
    }
    public bool IsMountainBreed
    {
        get => isMountainBreed;
        set
        {
            NotifyMountainChange(value);
            isMountainBreed = value;
        }
    }
    public MovmentContext()
    {

    }

    public MovmentContext(bool hasForestWalker, bool isRaining, bool isMountainBreed)
    {
        HasForestWalker = hasForestWalker;
        IsRaining = isRaining;
        IsMountainBreed = isMountainBreed;
    }
    private void NotifyForestChange(bool selector)
    {
        Console.WriteLine(selector ? ForestWalkerGained: ForestWalkerLost);
    }
    private void ToggleRain(bool selector)
    {
        Console.WriteLine(selector ? RainStarted : RainStopped);
    }
    private void NotifyMountainChange(bool selector)
    {
        Console.WriteLine(selector ? MountainBreedGained : MountainBreedLost);
    }
    public void MovmentContextDescription()
    {
        string conditions = string.Empty;
        if (HasForestWalker) conditions += "Лесной путник";
        if (IsRaining) conditions += " Дождь";
        if (IsMountainBreed) conditions += " Горец";

        Console.WriteLine(conditions);
    }

}