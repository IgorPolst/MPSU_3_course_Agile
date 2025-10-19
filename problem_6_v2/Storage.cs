using System.Data;
using problem_6_v2.TypeStorage;

namespace problem_6_v2;


public class Storage
{
    private string nameStorage = string.Empty;
    private StorageTier storageType = new Standard();
    private StorageContext context = new StorageContext();

    public int Capacity => StorageType.GetModifiedCost(Context);
    
    public string NameStorage
    {
        get => nameStorage;
        set => nameStorage = value ?? throw new ArgumentException(NameError);
    }

    public StorageTier StorageType
    {
        get => storageType;
        set => storageType = value;
    }

    public StorageContext Context
    {
        get => context;
        set => context = value; 
    }

    public Storage() { }

    public Storage(string name, StorageTier storageType, StorageContext context)
    {
        NameStorage = name;
        StorageType = storageType;
        Context = context;
    }

    public void UpdateStorageClass(StorageTier storage)
    {
        StorageType = storage;
    }
    
    public void StorageDiscriotion()
    {
        Console.WriteLine(string.Format(
            StorageDiscription, NameStorage, StorageType.TypeStorage, Capacity));
    }

    private const string NameError = "Имя не может быть пустым";
    private const string StorageDiscription = "Название: {0}\nТип хранилища: {1}\nОбъём: {2}Gb";
}