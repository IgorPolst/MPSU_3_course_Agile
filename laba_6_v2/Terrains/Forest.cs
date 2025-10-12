namespace laba_6_v2.Terrains;

public class Forest : Terrain
{
    public Forest()
    {
        BaseCost = 2;
        Name = "Лес";
    }

    public override int GetCost(MovmentContext context)
    {
        return context.HasForestWalker ? BaseCost - 1 : BaseCost;
    }
}
