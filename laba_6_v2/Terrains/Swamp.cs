namespace laba_6_v2.Terrains;

public class Swamp : Terrain
{
    public Swamp()
    {
        BaseCost = 3;
        Name = "Болото";
    }

    public override int GetCost(MovmentContext context)
    {
        return context.IsRaining ? BaseCost + 1 : BaseCost;
    }
}