using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;


namespace problem_6;

using static StorageClassExtention;

public static class RetrievalCostCalculatorEnum

{
    public static int CalculateCost(StorageClass storage, StorageContext context)
    {
        int baseCost = storage.GetBaseValue();
        int finalCost = ApplyModifiers(baseCost, storage, context);
        return Math.Max(finalCost,1);
    }

    private static int ApplyModifiers(int baseCost, StorageClass storage, StorageContext context)
    {
        int modifiedCost = baseCost;

        switch (storage)
        {
            case StorageClass.Standard:
            case StorageClass.InfrequentAccess:
            case StorageClass.Archive:
            case StorageClass.DeepArchive:

                if (context.IsExpedited)
                    modifiedCost += 3;
                if (context.IsCrossRegion)
                    modifiedCost += 1;
                if (context.HasWeekendMaintenance)
                    modifiedCost -= 1;
                break;
            default:
                break;
        }

        return modifiedCost;
    }

}