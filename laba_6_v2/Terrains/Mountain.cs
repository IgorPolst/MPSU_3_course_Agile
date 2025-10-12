namespace laba_6_v2.Terrains;

public class Mountain: Terrain
{
    public Mountain()
    {
        BaseCost = 4;  
        Name = "Горы"; 
    }

    public override int GetCost(MovmentContext context)
    {
        return context.IsMountainBreed ? BaseCost - 2 : BaseCost;
    }
}
