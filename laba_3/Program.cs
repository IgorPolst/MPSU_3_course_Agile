namespace laba_3;

class Program
{
    static void Main(string[] args)
    {
        var s1 = new Smartphone("Apple", 3000, "320*480px");
        Console.WriteLine(s1.ShowDeviceInfo());

        var l1 = new Laptop("Chuwi", 5000, 3.4);
        Console.WriteLine(l1.ShowDeviceInfo());

    }


}