using System;

class Program
{
    public static void Main(string[] args)
    {

        var s = new Sensor();
        s.Activate();
        Console.WriteLine(s.Info());
        Console.WriteLine($"Read: {s.Read()}\n");

        var t = new Thermometer(22.5);
        t.Activate();
        Console.WriteLine(t.Info());
        Console.WriteLine($"Temperature: {t.Read()} °C\n");

        var h = new Hygrometer(50);
        h.Activate();
        Console.WriteLine(h.Info());
        Console.WriteLine($"Humidity: {h.Read()}\n");


        var sh = new SmartHygrometer(40, 5);
        sh.Activate();
        Console.WriteLine(sh.Info());
        Console.WriteLine($"Smart Humidity: {sh.Read()}\n");

    }
}
