namespace problem_7;

public class Program
{
    public static void Main(string[] args)
    {
        var storeContext = new StoreContext(true, true, 10);
        var pipeline = new ScoringPipline();
        pipeline.AddRule(FirstPurchaseBonus);
        pipeline.AddRule(ReferralBonus);
        pipeline.AddRule((StoreContext context) =>
        {
            context.TotalScore += context.ItemsCount * 5;
        }
        );

        pipeline.Run(storeContext);
        Console.WriteLine($"Общий счет: {storeContext.TotalScore}");
        Console.WriteLine();

        pipeline.RemoveRule(ReferralBonus);

        storeContext = new StoreContext(true, true, 10);

        pipeline.Run(storeContext);
        Console.WriteLine($"Общий счет: {storeContext.TotalScore}");
    }

    public static void FirstPurchaseBonus(StoreContext context)
    {
        if (context.IsFirstPurchase)
    {
        context.IsFirstPurchase = false;
        context.TotalScore += 10;
    }
    }
    public static void ReferralBonus(StoreContext context)
    {
        if (context.HasReferral)
        {
            context.HasReferral = false;
            context.TotalScore += 20;
        }
    }


}