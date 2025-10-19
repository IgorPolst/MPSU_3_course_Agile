namespace problem_6_v2;

public abstract class StorageTier
{
    private int baseCost;
    private string typeStorage;
    public int BaseCost
    {
        get => baseCost;
        protected set => baseCost = value;
    }

    public string TypeStorage
    {
        get => typeStorage;
        protected set => typeStorage = value;
    }
    
    protected StorageTier(int cost, string typeStore)
    {
        baseCost = cost;
        typeStorage = typeStore;
    }
    public virtual int GetRetrievalCost()
    {
        return BaseCost;
    }

    public virtual int GetModifiedCost(StorageContext context)
    {
        int modifiedCost = BaseCost;
        if (context.IsExpedited)
            modifiedCost += 3;
        if (context.IsCrossRegion)
            modifiedCost += 1;
        if (context.HasWeekendMaintenance)
            modifiedCost -= 1;

        return modifiedCost;

    }
}