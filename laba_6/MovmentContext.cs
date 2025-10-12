
namespace laba_6;

public class MovmentContext
{
    private bool hasForestWalker;
    private bool isRaining;
    private bool isMountainBreed;

    public bool HasForestWalker
    {
        get => hasForestWalker;
        set => hasForestWalker = value;
    }
    public bool IsRaining
    {
        get => isRaining;
        set => isRaining = value;
    }
    public bool IsMountainBreed
    {
        get => isMountainBreed;
        set => isMountainBreed = value;
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

    public override string ToString()
    {
        var conditions = new List<string>();

        if (HasForestWalker) conditions.Add("Лесной путник");
        if (IsRaining) conditions.Add("Дождь");
        if (IsMountainBreed) conditions.Add("Горец");

        return conditions.Count > 0
            ? string.Join(", ", conditions)
            : "Обычные условия";
    }

}