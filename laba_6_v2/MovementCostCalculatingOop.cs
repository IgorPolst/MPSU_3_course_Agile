namespace laba_6_v2;

public static class MovementCostCalculatingOop
{
    public static int CalculateCost(MovmentContext context, Terrain terrain)
    {
        return terrain.GetCost(context);
    }
}