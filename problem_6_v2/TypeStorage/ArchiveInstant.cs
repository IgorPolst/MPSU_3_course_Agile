namespace problem_6_v2.TypeStorage;
public class ArchiveInstant : StorageTier
{
    public ArchiveInstant() : base(5, "Мнгновенный архив") { }

    public override int GetModifiedCost(StorageContext context)
    {
        return GetRetrievalCost();
    }
}