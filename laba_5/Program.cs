namespace laba_5;

public class Program
{
    public static void Main()
    {
        var combo = new ComboDevice("Combo1");
        var hub = new HubController("MainHub", "Hub1", 25);
        var aggregator = new WeatherAgregator("Agg1", "Aggregator", combo);

    
        combo.UpdateMeasurement(28);   
        combo.Report(hub);

        hub.Route(combo, combo);       

        aggregator.Route(combo, combo); 
        aggregator.Report(hub);         
    }
}