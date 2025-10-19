namespace problem_6;

public static class StorageClassExtention
{
    public static int GetBaseValue(this StorageClass storageClass)
    {
        return storageClass switch
        {
            StorageClass.Standard => 1,
            StorageClass.InfrequentAccess => 2,
            StorageClass.Archive => 4,
            StorageClass.DeepArchive => 6,
            StorageClass.ArchiveInstant => 5,
            _ => throw new ArgumentOutOfRangeException(nameof(storageClass), storageClass, null)
        };
    }

    public static string GetBaseName(this StorageClass storageClass)
    {
        return storageClass switch
        {
            StorageClass.Standard => "Стандартный",
            StorageClass.InfrequentAccess => "Нечастый доступ",
            StorageClass.Archive => "Архивный",
            StorageClass.DeepArchive => "Глубокий архив",
            StorageClass.ArchiveInstant => "Мнгновенный архив",
            _ => throw new ArgumentOutOfRangeException(nameof(storageClass), storageClass, null)
        };
    }
}
