namespace laba_6_v2;

using static Messages.GameErrorMessages;
public abstract class Terrain
{
    private int baseCost;
    private string name = string.Empty;


    public int BaseCost
    {
        get => baseCost;
        set => baseCost = Math.Max(1, value);
    }

    public string Name{
        get => name;
        set => name = value ??
            throw new ArgumentException(InvalidName); 
    }

    public virtual int GetCost(MovmentContext context)
    {
        return BaseCost;
    }
}
