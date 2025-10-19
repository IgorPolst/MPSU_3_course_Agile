namespace problem_6;

using static RetrievalCostCalculatorEnum;
public class Program
{
    public static void Main(string[] arg)
    {
        var context1 = new StorageContext(true, false, true);
        var context2 = new StorageContext(false, true, false);
        
        var storage1 = new Storage("Быстрый архив", StorageClass.Archive, context1);
        var storage2 = new Storage("Межрегиональный стандарт", StorageClass.Standard, context2);
        
        
        storage1.StorageDiscriotion();
        storage2.StorageDiscriotion();
        
        storage1.UpdateStorageClass(StorageClass.DeepArchive);
        storage1.StorageDiscriotion();
    }

}
