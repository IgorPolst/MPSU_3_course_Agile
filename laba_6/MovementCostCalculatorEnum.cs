using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace laba_6;

public static class MovmentCostCalculatingEnum
{
    public static int CalculateCost(TerrainType terrain, MovmentContext context)
    {
        int baseCost = GetBaseCost(terrain);
        int finalCost = ApplyModifiers(baseCost, terrain, context);

        return Math.Max(finalCost, 1);
    }
    private static int GetBaseCost(TerrainType terrain)
    {
        return terrain switch
        {
            TerrainType.Plain => 1,
            TerrainType.Forest => 2,
            TerrainType.Swamp => 3,
            TerrainType.Mountain => 4,
            TerrainType.Road => 1,
            _ => 1
        };
    }

    private static int ApplyModifiers(int baseCost, TerrainType terrain, MovmentContext context)
    {
        int modifiedCost = baseCost;

        switch (terrain)
        {
            case TerrainType.Forest:
                if (context.HasForestWalker)
                    modifiedCost -= 1;
                break;

            case TerrainType.Swamp:
                if (context.IsRaining)
                    modifiedCost += 1;
                break;

            case TerrainType.Mountain:
                if (context.IsMountainBreed)
                    modifiedCost -= 2;
                break;

            case TerrainType.Plain:
                break;
        }

        return modifiedCost;
    }

    public static string GetTerrainDescription(TerrainType terrain)
    {
        return terrain switch
        {
            TerrainType.Plain => "Равнина",
            TerrainType.Forest => "Лес",
            TerrainType.Swamp => "Болото",
            TerrainType.Mountain => "Горы",
            TerrainType.Road => "Дорога",
            _ => "Неизвестная местность"
        };
    }

}