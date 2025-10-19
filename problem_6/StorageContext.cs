namespace problem_6;

public class StorageContext
{
    
    private bool isExpedited;
    private bool isCrossRegion;
    private bool hasWeekendMaintenance;
    
    public bool IsExpedited
    {
        get => isExpedited;
        set => isExpedited = value;
    }

    public bool IsCrossRegion
    {
        get => isCrossRegion;
        set => isCrossRegion = value;
    }

    public bool HasWeekendMaintenance
    {
        get => hasWeekendMaintenance;
        set => hasWeekendMaintenance = value;
    }

    public StorageContext() { }

    public StorageContext(
        bool isExpedited, bool isCrossRegion, bool hasWeekendMaintenance)
    {
        IsExpedited = isExpedited;
        IsCrossRegion = isCrossRegion;
        HasWeekendMaintenance = hasWeekendMaintenance;
    }

    public override string ToString()
    {
        var conditions = new List<string>();
        if (IsExpedited) conditions.Add("Срочный");
        if (IsCrossRegion) conditions.Add("Межрегиональный");
        if (HasWeekendMaintenance) conditions.Add("Обслуживание по выходным");
        
        return conditions.Count > 0
            ? string.Join(", ", conditions)
            : "Обычные условия";
    }

}