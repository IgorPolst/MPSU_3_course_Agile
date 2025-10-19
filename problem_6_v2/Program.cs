namespace problem_6_v2;

using TypeStorage;

public class Program
{
    public static void Main(string[] arg)
    {
        var fastAccess = new StorageContext(isExpedited: true, isCrossRegion: false, hasWeekendMaintenance: true);
        var crossRegion = new StorageContext(isExpedited: false, isCrossRegion: true, hasWeekendMaintenance: false);
        var weekendSpecial = new StorageContext(isExpedited: false, isCrossRegion: false, hasWeekendMaintenance: true);
        
        var backupStorage = new Storage("Резервные копии", new Archive(), fastAccess);
        var userFiles = new Storage("Файлы пользователей", new Standard(), crossRegion);
        var coldStorage = new Storage("Холодные данные", new DeepArchive(), weekendSpecial);
        
        backupStorage.StorageDiscriotion();
        userFiles.StorageDiscriotion();
        coldStorage.StorageDiscriotion();
        
        backupStorage.UpdateStorageClass(new InfrequentAccess());
        backupStorage.StorageDiscriotion();

        var defaultStorage = new Storage();
        defaultStorage.NameStorage = "Новое хранилище";
        defaultStorage.StorageDiscriotion();}

}
