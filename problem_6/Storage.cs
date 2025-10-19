using System.Data;

namespace problem_6;
using static RetrievalCostCalculatorEnum;
public class Storage
{
    private string nameStorage = string.Empty;
    private StorageClass storageType;
    private StorageContext context = new StorageContext();

    public int Capacity => CalculateCost(StorageType, Context);
    
    public string NameStorage
    {
        get => nameStorage;
        set => nameStorage = value ?? throw new ArgumentException(NameError);
    }

    public StorageClass StorageType
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

    public Storage(string name, StorageClass storageType, StorageContext context)
    {
        NameStorage = name;
        StorageType = storageType;
        Context = context;
    }

    public void UpdateStorageClass(StorageClass storage)
    {
        StorageType = storage;
    }
    
    public void StorageDiscriotion()
    {
        Console.WriteLine(string.Format(
            StorageDiscription, NameStorage, StorageType, Capacity));
    }

    private const string NameError = "Имя не может быть пустым";
    private const string StorageDiscription = "Название: {0}\nТип хранилища: {1}\nОбъём: {2}Gb";
}