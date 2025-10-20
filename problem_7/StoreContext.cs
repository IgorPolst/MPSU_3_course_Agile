using System.Runtime.CompilerServices;

namespace problem_7;

public class StoreContext
{
    private int totalScore;
    private int itemsCount;
    private bool isFirstPurchase;
    private bool hasReferral;

    public int ItemsCount
    {
        get => itemsCount;
        set => itemsCount = value >= 0 ? value : 
        throw new ArgumentException(MessageIntError);
    }
    public bool IsFirstPurchase
    {
        get => isFirstPurchase;
        set => isFirstPurchase = value;
    }
    public bool HasReferral
    {
        get => hasReferral;
        set => hasReferral= value;
    }
    public int TotalScore
    {
        get => totalScore;
        set => totalScore = value >= 0 ? value :
        throw new ArgumentException(MessageIntError);
    }

    public StoreContext() { }
    public StoreContext(bool isFirstPurchase, bool hasReferral, int itemsCount, int totalScore = 0)
    {
        TotalScore = totalScore;
        ItemsCount = itemsCount;
        IsFirstPurchase = isFirstPurchase;
        HasReferral = hasReferral;
    }
    
    private const string MessageIntError = "Значение не может быть пустым или меньще 0";
}